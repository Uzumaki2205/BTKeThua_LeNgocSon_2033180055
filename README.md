# BÀI TẬP KẾ THỪA
## Bài 1. Một người bao gồm các thông tin: họ tên, ngày sinh, giới tính (giới tính là “nam” hoặc “nữ”).
## Nhân viên của một công ty là một người và có thêm các thuộc tính: mã số nhân viên, lương cơ bản, chức vụ và hệ số chức vụ. 
### Hệ thống quản lý bao gồm các yêu cầu chi tiết như sau:
### a. Lớp người:
- Xây dựng lớp với các thuộc tính trên.
- Xây dựng phương thức khởi tạo mặc định. Giới tính mặc định là “nam”.
- Xây dựng phương thức khởi tạo có tham số, nếu tham số giới tính truyền vào 
không rơi vào một trong hai trường hợp “nam” hoặc “nữ” thì thuộc tính giới tính là “nam”
- Xây dựng phương thức xuất thông tin một người.
### b. Lớp nhân viên
- Xây dựng lớp nhân viên kế thừa lớp người và các thuộc tính bổ sung
- Xây dựng phương thức khởi tạo có tham số. Thuộc tính hệ số chức vụ được tính như sau:
- Nếu chức vụ là “giám đốc” thì hệ số chức vụ là 2.0
- Nếu chức vụ là “trưởng phòng” thì hệ số chức vụ là 1.5, còn lại là 1.0
- Xây dựng phương xuất thông tin nhân viên.
- Xây dựng phương thức tính lương = lương cơ bản + hệ số chức vụ * lương cơ bản
+ phụ cấp ưu đãi (nếu là nữ thì phụ cấp ưu đãi là 50% của lương cơ bản, ngược lại
không có).
### c. Nhân viên công ty chia làm 3 loại: Nhân viên hành chính, nhân viên làm theo ca và nhân viên thời vụ (làm theo sản phẩm).
- Nhân viên hành chính có thêm các thông tin hệ số lương, số ngày làm và hệ số thi đua, biết rằng:
+ số ngày làm > 25: hệ số thi đua là 1.0, ngược lại
+ số ngày làm >20: hệ số thi đua là 0.75, ngược lại
+ số ngày làm > 15: hệ số thi đua là 0.5, ngược lại là 0.0
### Lương của NVHC = 1000+hệ số lương*hs thi đua *1150.
- Nhân viên làm theo ca có thêm số ca làm việc.
### Lương của NVTC = 1000+số ca tính tiền*200. 
Biết rằng: số ca<=24 thì số ca tính tiền = số ca, ngược lại số ca vượt sẽ được tính gấp 2.
- Nhân viên thời vụ có thêm số sản phẩm đã làm. Lương của NVTV = số sản phẩm*100.
### d. Cho danh sách chứa các nhân viên (List<NV> lsnv), hãy viết các hàm:
- Tính tổng lương của các nhân viên.
- Đếm số nhân viên của từng loại.
- Xuất thông tin các nhân viên hành chính có hệ số thi đua là 1.0
- Xuất thông tin nhân viên có lương cao nhất/thấp nhất
## Bài 2. Một người bao gồm các thông tin: họ tên, ngày sinh, giới tính (giới tính là “nam” hoặc “nữ”). 
## Sinh viên của một trường là một người và có thêm các thuộc tính: mã số sinh viên, hệ đào tạo, tổng số tín chỉ. 
### Hệ thống quản lý bao gồm các yêu cầu chi tiết như sau:
### a. Lớp người:
- Xây dựng lớp với các thuộc tính trên.
- Xây dựng phương thức khởi tạo mặc định. Giới tính mặc định là “nam”
- Xây dựng phương thức khởi tạo có tham số, nếu tham số giới tính truyền vào không rơi vào một trong hai trường hợp “nam” hoặc “nữ” thì thuộc tính giới tính là “nam”
- Xây dựng phương thức xuất một người
### b. Lớp sinh viên
- Xây dựng lớp sinh viên kế thừa lớp người và các thuộc tính bổ sung.
- Xây dựng phương thức khởi tạo có tham số. Thuộc tính hệ đào tạo là một trong 3 giá trị “đại học”, “cao đẳng” và “cao đẳng nghề”. 
Nếu tham số hệ đào tạo không thuộc một trong ba trường hợp này thì thiết lập hệ đào tạo là “đại học”. 
Thuộc tính tổng số tín chỉ được tính như sau:
- Nếu hệ đào tạo là “đại học” thì tổng số tín chỉ là 150
- Nếu hệ đào tạo là “cao đẳng” thì tổng số tín chỉ là 100
- Nếu hệ đào tạo là “cao đẳng nghề” thì tổng số tín chỉ là 130
- Xây dựng phương xuất sinh viên
- Xây dựng phương thức tính tổng học phí của sinh viên như sau: 
### tổng học phí = tổng số tín chỉ * học phí tín chỉ.
Trong đó, học phí tín chỉ được tính như sau:
- Nếu hệ đào tạo là “đại học” thì học phí tín chỉ = 200.000
- Nếu hệ đào tạo là “cao đẳng” thì học phí tín chỉ = 150.000
- Nếu hệ đào tạo là “cao đẳng nghề” thì học phí tín chỉ = 120.000
## Bài 3. Một người bao gồm các thông tin: họ tên, ngày sinh, giới tính (giới tính là “nam” hoặc “nữ”). 
## Giảng viên của một trường là một người và có thêm các thuộc tính: mã số, lương cơ bản, hệ số, chức vụ. 
### Hệ thống quản lý bao gồm các yêu cầu chi tiết như sau:
### a. Lớp người:
- Xây dựng lớp với các thuộc tính trên.
- Xây dựng phương thức khởi tạo mặc định. Giới tính mặc định là “nam”- Xây dựng phương thức khởi tạo có tham số, nếu tham số giới tính truyền vào
không rơi vào một trong hai trường hợp “nam” hoặc “nữ” thì thuộc tính giới tính là “nam”
- Xây dựng phương thức xuất một người
### b. Lớp giảng viên
- Xây dựng lớp giảng viên kế thừa lớp người và các thuộc tính bổ sung.
- Xây dựng phương thức khởi tạo có tham số. Thuộc tính hệ số là một trong các giá
trị 2.34, 2.67, 3.0 và 3.3. Nếu tham số hệ số không thuộc một trong ba trường hợp
này thì thiết lập hệ số là 2.34. Thuộc tính chức vụ là một trong ba giá trị “trưởng
khoa”, “phó khoa” và “giảng viên”. Nếu chức vụ không rơi vào một trong ba giá trị này thì thiết lập nó là “giảng viên”.
- Xây dựng phương thức xuất giảng viên
- Xây dựng phương thức tính lương của giảng viên như sau: lương = lương cơ bản * hệ số + phụ cấp chức vụ (PCCV). 
Trong đó, phụ cấp chức vụ được tính như sau:
- Nếu chức vụ là “trưởng khoa” thì PCCV = 5 * lương cơ bản
- Nếu chức vụ là “phó khoa” thì PCCV = 4 * lương cơ bản
- Giảng viên không có PCCV (hay PCCV = 0)
### c. Giảng viên gồm có 2 dạng: giảng viên cơ hữu và giảng viên thỉnh giảng. Cách tính vượt giờ của mỗi loại GV như sau:
- Giảng viên cơ hữu: tùy theo trình độ và tình trạng đang đi học hoặc không đi học nâng cao mà có số tiết dạy chuẩn trong 1 năm theo qui định sau:
+ GV trình độ cử nhân và không đi học: 300 tiết và hệ số dạy 1.0
+ GV trình độ cử nhân và đang học Thạc sĩ: 210 tiết và hệ số dạy 1.0
+ GV trình độ thạc sĩ và không đi học: 300 tiết và hệ số dạy 1.5
+ GV trình độ thạc sĩ và đang đi học tiến sĩ: 150 tiết và hệ số dạy là 1.5
+ GV trình độ tiến sĩ: 300 và hệ số dạy là 2.5
- Tính tiền vượt giờ: (tổng số giờ dạy - số tiết dạy chuẩn) * hệ số dạy * 60
- Giảng viên thỉnh giảng được tính tiền vượt giờ như sau:
+ GV có trình độ cử nhân: số tiết dạy * 60
+ GV có trình độ thạc sỹ: số tiết dạy * 100
+ GV có trình độ tiến sĩ: số tiết dạy * 250
### d. Cho danh sách các giảng viên, hãy viết hàm tính các yêu cầu sau:
- Tính tổng tiền vượt giờ của các giảng viên.
- Đếm số giảng viên mỗi loại.
- Tìm giảng viên cơ hữu có số tiết dạy vượt giờ nhiều nhất.
- Xuất danh sách các giảng viên dạy cơ hữu thiếu giờ qui định.
- Tìm giảng viên có số tiền vượt giờ nhiều nhất/ít nhất.
- Đếm số giảng viên có trình độ cử nhân/thạc sỹ/tiến sĩ.
## Bài 4. Một hàng hóa bao gồm các thông tin: mã hàng và tên hàng. 
## Nước giải khát là một hàng hóa và có thêm các thuộc tính: đơn vị tính, số lượng, đơn giá. 
### Hệ thống quản lý bao gồm các yêu cầu chi tiết như sau:
### a. Lớp hàng hóa:
- Xây dựng lớp với các thuộc tính trên.
- Xây dựng phương thức khởi tạo mặc định, mã hàng và tên hàng đều rỗng
- Xây dựng phương thức khởi tạo có tham số. Mã hàng có kiểu chuỗi có chiều dài là 5 ký tự, 2 ký tự đầu là “HH”, 3 ký tự sau là số. 
- Nếu tham số mã hàng không đúng quy tắc này thì thì khởi tạo mã hàng là “HH001”
- Xây dựng phương thức xuất một hàng hóa
### b. Lớp Nước giải khát
- Xây dựng lớp Nước giải khát kế thừa lớp hàng hóa và các thuộc tính bổ sung.
- Xây dựng phương thức khởi tạo có tham số. Lưu ý: đơn vị tính chỉ nhận 1 trong 4 giá trị: “kết”, “thùng”, “chai”, “lon”. 
- Nếu đơn vị tính không thuộc 1 trong 4 tham số trên thì gán đơn vị tính là “kết”
- Xây dựng phương thức xuất Nước giải khát
- Xây dựng phương thức thành tiền dựa vào đơn vị tính (DVT) như sau:
- DVT = “kết” hoặc “thùng” -> thành tiền = số lượng * đơn giá
- DVT = “chai” -> thành tiền = số lượng * đơn giá / 20
- DVT = “lon” -> thành tiền = số lượng * đơn giá /24
## Bài 5. Một hàng hóa bao gồm các thông tin: mã hàng và tên hàng. 
## Dầu gội là một hàng hóa và có thêm các thuộc tính: đơn vị tính, số lượng, đơn giá, xuất xứ.
## Nước giải khát là một hàng hóa và có thêm các thuộc tính: đơn vị tính, số lượng, đơn giá.
### Hệ thống quản lý bao gồm các yêu cầu chi tiết như sau:
### e. Lớp hàng hóa:
- Xây dựng lớp với các thuộc tính trên.
- Xây dựng phương thức khởi tạo mặc định, mã hàng và tên hàng đều rỗng
- Xây dựng phương thức khởi tạo có tham số. Mã hàng có kiểu chuỗi có chiều dài là 5 ký tự, 2 ký tự đầu là “MH”, 3 ký tự sau là số. 
- Nếu tham số mã hàng không đúng quy tắc này thì thì khởi tạo mã hàng là “MH001”
- Xây dựng phương thức xuất một hàng hóa
### f. Lớp Dầu gội:
- Xây dựng lớp Dầu gội kế thừa lớp hàng hóa và các thuộc tính bổ sung.
- Xây dựng phương thức khởi tạo có tham số. Lưu ý: đơn vị tính chỉ nhận 1 trong 3 giá trị: “chai”, “bịch” và “hộp”. 
- Nếu đơn vị tính không thuộc 1 trong 3 tham số trên thì gán đơn vị tính là “chai”. 
- Xuất xứ chỉ nhận 1 trong 2 giá trị “Trong nước” và “Nước ngoài”, nếu xuất xứ không thuộc 1 trong 2 giá trị này thì gán xuất xứ là “Trong nước”
- Xây dựng phương thức xuất Dầu gội
- Xây dựng phương thức thành tiền dựa vào đơn vị tính (DVT) và xuất xứ như sau:
- Nếu xuất xứ là “trong nước”
- Nếu DVT là “chai” hoặc “hộp” thì thành thành tiền = số lượng * đơn giá
- Nếu DVT là “bịch” thì thành tiền = số lượng * đơn giá / 50
- Nếu xuất xứ là “nước ngoài”: cách tính tương tự như “trong nước” đồng thời cộng thêm 0.5 * thành tiền
### g. Lớp nước giải khát
- Xây dựng lớp Nước giải khát kế thừa lớp hàng hóa và các thuộc tính bổ sung.
- Xây dựng phương thức khởi tạo có tham số. Lưu ý: đơn vị tính chỉ nhận 1 trong 4 giá trị:
“kết”, “thùng”, “chai”, “lon”. Nếu đơn vị tính không thuộc 1 trong 4 tham số trên thì gán đơn vị tính là “kết”
- Xây dựng phương thức xuất Nước giải khát
- Xây dựng phương thức thành tiền dựa vào đơn vị tính (DVT) như sau:
- DVT = “kết” hoặc “thùng” -> thành tiền = số lượng * đơn giá
- DVT = “chai” -> thành tiền = số lượng * đơn giá / 20
- DVT = “lon” -> thành tiền = số lượng * đơn giá / 24
### h. Nước giải khát chia làm 2 loại: nước có gas và nước không có gas. 
Cần tính lại thành tiền của mỗi loại vì các tính thuế mỗi loại khác nhau:
- Đối với nước có gas: 7%
- Đối với nước không có gas: 2%
## Bài 6. Thiết kế và xây dựng lớp cho chương trình tính tiền phòng hàng tháng cho một cơ sở cho thuê phòng trọ. 
## Biết rằng mỗi phòng đều có thông tin sau: Mã số phòng, số người ở, số điện và số nước. 
### Tiền phòng = 1500 * số điện * 3 + số nước * 10.
Cơ sở chia phòng ra làm 2 loại khác nhau:
- Phòng loại A: Có thêm thông tin về số lần người thân thăm và ở lại qua đêm (Nguoithan)
### Tiền phòng được tính như sau:
### Tiền phòng = 1400 + 2 * số điện + 8 * số nước + 50 * Nguoithan
- Phòng loại B: Có thêm thông tin khối lượng giặt ủi (giatui), và số máy sử dụng internet (somay). 
###Tiền phòng được tính như sau:
### Tiền phòng = 2000 + 2 * số điện + 8 * số nước + giatui * 5 + somay * 100
## Bài 7. Cục quản lý đường bộ cần quản lý các phương tiện giao thông. 
## Mỗi phương tiện giao thông chứa các thông tin: biển số, tên xe, giá trị, thuế trước bạ. 
### Biết rằng thuế trước bạ = 10% * giá trị.
Họ quản lý 2 loại xe chính:
- Xe gắn máy: có thêm thông tin phân khối, và thuế trước bạ = 15% * giá trị + phân khối * 2%.
- Xe ô tô: có thêm thông tin số chỗ ngồi, và thuế trước bạ = 20% * giá trị + số chỗ ngồi * 10%.
### Hãy xây dựng các lớp để quản lý thông tin và việc tính thuế trước bạ cho các phương tiện trên.