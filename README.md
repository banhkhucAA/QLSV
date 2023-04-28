# Quản lý sinh viên dotnet Winform
Đây là chương trình được xây dựng bằng ngôn ngữ C# dotnet trên Winform của Microsoft Visual stuido, kết hợp với đó là SqlServer.

Chương trình chia làm 4 người sử dụng là Phòng quản lý đào tạo, sinh viên, giáo viên và Admin với các chức năng khác nhau.
+ Phòng quản lý đào tạo có 5 chức năng chính đó là quản lý môn học, 
quản lý các lớp học phần (theo môn học, ví dụ như môn thiết kế web, lập trình java,...), 
quản lý các lớp (theo chuyên ngành học, ví dụ như công nghệ thông tin, thương mại điện tử, 
quản lý ngành/khoa/viện và phòng bộ môn (thuộc khoa/viện) mà giáo viên thuộc về
+ Admin là người quản trị viên, có chức năng quản lý thông tin của sinh viên, giáo viên
và thay đổi mật khẩu của các tài khoản trong người dùng hệ thống (trong trường hợp họ quên hoặc cần reset tài khoản)
+ Sinh viên có các chức năng cơ bản như 
chỉnh sửa thông tin cá nhân của mình trên hệ thống (ngoại trừ mã ngành học, chỉ có admin mới có thể thay đổi mã ngành học), 
đăng ký môn học (có kiểm tra các ràng buộc), tra cứu điểm quá trình và lịch học, xuất file sang Excel
+ Giáo viên có các chức năng cơ bản như Cập nhật thông tin của chính mình, 
chấm điểm cho sinh viên theo lớp học phần, 
xem danh sách sinh viên – thông tin sinh viên theo lớp học phần. 
Nếu giáo viên có chức vụ là trưởng bộ môn, sẽ có thêm chức năng là phân chia giảng viên cho các lớp học phần.
