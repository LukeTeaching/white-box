# Cài đặt các Package cần thiết

```
# Cài đặt Coverlet để thu thập dữ liệu coverage
dotnet add package coverlet.collector

# Cài đặt ReportGenerator làm công cụ toàn cục (chỉ cần cài 1 lần trên máy)
dotnet tool install --global dotnet-reportgenerator-globaltool
```

# Quy trình thực hiện (Workflow)
- Bước 1: Chạy Test và xuất dữ liệu thô. Thay vì chỉ chạy dotnet test, bạn thêm tham số để kích hoạt Coverlet:
			```
			dotnet test --collect:"XPlat Code Coverage"
			```
			Kết quả: Một thư mục TestResults sẽ xuất hiện, bên trong có một file tên là coverage.cobertura.xml. Đây là file máy đọc, chúng ta chưa đọc được ngay.
- Bước 2: Chuyển đổi sang báo cáo HTML trực quan. Sử dụng ReportGenerator để quét thư mục TestResults và tạo trang web:
			```
			reportgenerator -reports:"TestResults/**/coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
			```