# OOP
I.	Yêu cầu thực tiễn
1khách sạn có nhiều nhân viên, phân biệt qua mã nhân viên, 1 nv thuộc 1 nhóm nv, các nhóm nv phân biệt qua mã nhóm.
Các công việc trong khách sạn phân biệt qua mã công việc, mỗi công việc thuộc 1 nhóm cv, phân biệt qua mã nhóm CV
Khách hàng khi đến khách sạn, sẽ có hợp đồng thuê phòng. Mỗi KH có 1 mã KH, thuộc 1 loại KH. Mỗi loại KH phân biệt qua mã loại KH. 
Mỗi phòng phân biệt với nhau qua số phòng, mỗi phòng thuộc một loại phòng, mỗi loại phòng được phân biệt với nhau qua mã loại phòng.
Trong phòng sẽ có nhiều thiết bị phân biệt qua mã thiết bị mỗi thiết bị thuộc một loại thiết bị,phân biệt qua mã loại thiết bị.
Hợp đồng phân biệt qua mã hợp đồng, và mỗi hợp đồng chỉ thuê 1 phòng và 1 KH đứng ra thuê.
Mỗi HD sẽ có nhiều dịch vụ trong một dịch vụ có nhiều công việc, nhưng 1 công việc trong dịch vụ sẽ giao cho một nhân viên phụ trách, các dịch vụ phân biệt với nhau qua mã dịch vụ.
Mỗi công việc phân biệt qua mã công việc, mỗi công việc thuộc nhóm công việc, mỗi nhóm công việc phân biệt qua mã nhóm.
Mỗi nhân viên phân biệt qua mã nhân viên,mỗi nhân viên thuộc một nhóm nhân viên, mỗi nhóm nhân viên phân biệt qua mã nhóm NV,trong một nhóm nhân viên có một trưởng nhóm.
Mỗi hóa đơn có thể trả cho nhiều hợp đồng, mỗi hóa đơn chỉ do một nhân viên phụ trách thu tiền.
..............................................................................................................................................................
 

II.	Mô hình ERD
![alt text](https://github.com/CaoHoaiTan/OOP/blob/main/ERD/Demo.png)
 
III.	Mô hình quan hệ
NhanVien(maNV,tenNV,CMND,SDT,manhomNV...)
nhomNV(manhomNV,manhomtruong,...)
Khach(maKH,tenKH,CMND,SDT,maLK,...)
LoaiKhach(maLK,tenloaikhach,giatien,...)
Phong(soPhong,maLP,maThietbi,...)
LoaiPhong(maLP,tenLoaiPhong,songuoi,giatien,...)
Dichvu(maDV,giatien,...)
HopDong(SoHD,maKH,soPhong,maDV,phuongthucthanhtoan,giatien,ngaynhanphong,ngaytra,...)
HoaDon(soHoaDon,soHD,giatien,ngaythanhtoan,Nvthanhtoan,....)
congViec(maCV,tencongviec,manhomCV,...)
nhomCV(manhomCV,tennhom,....)
thietbi(maTB,tenTB,...)

//
LapHD(maKH,soPhong,soHD)
ThanhToan(soHoanDon,maNV,soHD)
ThaoTacDV(maNV,maDV,maCV)
 


