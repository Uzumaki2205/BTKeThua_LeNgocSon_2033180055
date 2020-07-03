# BÀI TẬP KẾ THỪA
## Bài 1. Một người bao gồm các thông tin: họ tên, ngày sinh, giới tính (giới tính là “nam” hoặc “nữ”).
Nhân viên của một công ty là một người và có thêm các thuộc tính: mã số nhân viên,
lương cơ bản, chức vụ và hệ số chức vụ. Hệ thống quản lý bao gồm các yêu cầu chi tiết
như sau:
### a. Lớp người:
- Xây dựng lớp với các thuộc tính trên.
- Xây dựng phương thức khởi tạo mặc định. Giới tính mặc định là “nam”
- Xây dựng phương thức khởi tạo có tham số, nếu tham số giới tính truyền vào
không rơi vào một trong hai trường hợp “nam” hoặc “nữ” thì thuộc tính giới tính là “nam”
- Xây dựng phương thức xuất thông tin một người.
### b. Lớp nhân viên
- Xây dựng lớp nhân viên kế thừa lớp người và các thuộc tính bổ sung
- Xây dựng phương thức khởi tạo có tham số. Thuộc tính hệ số chức vụ được tính như sau:
- Nếu chức vụ là “giám đốc” thì hệ số chức vụ là 2.0
- Nếu chức vụ là “trưởng phòng” thì hệ số chức vụ là 1.5
- Còn lại là 1.0
- Xây dựng phương xuất thông tin nhân viên.
- Xây dựng phương thức tính lương = lương cơ bản + hệ số chức vụ * lương cơ bản
+ phụ cấp ưu đãi (nếu là nữ thì phụ cấp ưu đãi là 50% của lương cơ bản, ngược lại
không có).
### c. Nhân viên công ty chia làm 3 loại: Nhân viên hành chính, nhân viên làm theo ca và nhân viên thời vụ (làm theo sản phẩm).
- Nhân viên hành chính có thêm các thông tin hệ số lương, số ngày làm và hệ số thi đua, biết rằng:
+ số ngày làm > 25: hệ số thi đua là 1.0, ngược lại
+ số ngày làm >20: hệ số thi đua là 0.75, ngược lại
+ số ngày làm > 15: hệ số thi đua là 0.5, ngược lại là 0.0
Lương của NVHC = 1000+hệ số lương*hs thi đua *1150.
- Nhân viên làm theo ca có thêm số ca làm việc.
Lương của NVTC = 1000+số ca tính tiền*200. Biết rằng: số ca<=24 thì số ca tính
tiền = số ca, ngược lại số ca vượt sẽ được tính gấp 2.
- Nhân viên thời vụ có thêm số sản phẩm đã làm. Lương của NVTV = số sản phẩm*100.
### d. Cho danh sách chứa các nhân viên (List<NV> lsnv), hãy viết các hàm:
- Tính tổng lương của các nhân viên.
- Đếm số nhân viên của từng loại.
- Xuất thông tin các nhân viên hành chính có hệ số thi đua là 1.0
- Xuất thông tin nhân viên có lương cao nhất/thấp nhất