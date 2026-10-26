=============================================================================
HQ13Demo - Đồ án Tham chiếu Chuẩn 4 Trụ Cột OOP & 5 Nguyên Lý SOLID
(C# WinForms, .NET Framework 4.7.2)
=============================================================================

Mở HQ13Demo.sln bằng Visual Studio -> Nhấn F5 để chạy.

-----------------------------------------------------------------------------
1. CẤU TRÚC KIẾN TRÚC & THƯ MỤC
-----------------------------------------------------------------------------
├── Models/
│   ├── ContainerInfo.cs             [OOP: Encapsulation - Đóng gói dữ liệu & validation]
│   └── CustomsClearanceResult.cs    [DTO kết quả thông quan]
│
├── Interfaces/
│   ├── ICustomsService.cs           [SOLID: Dependency Inversion (D), Interface Segregation (I)]
│   └── INotificationChannel.cs      [SOLID: Single Responsibility (S), Open/Closed (O)]
│
├── Services/
│   ├── CustomsService.cs            [SOLID: Single Responsibility (S) - chỉ lo hải quan]
│   └── Notifications/
│       └── MessageBoxNotificationChannel.cs      [Hiển thị Pop-up MessageBox]
│
└── Forms/
    ├── HQ13Base.cs                  [OOP: Kế thừa, Đa hình | virtual GetCustom()]
    ├── HQ13.cs                      [Kế thừa HQ13Base, dùng GetCustom() mặc định: "Cont A đã thông quan"]
    ├── HQ13A.cs                     [Kế thừa HQ13Base, override GetCustom(): "Cont A ISO 2300 đã thông quan"]
    └── FrmMain.cs                   [Menu điều hướng mở HQ13 và HQ13A]

-----------------------------------------------------------------------------
2. ÁNH XẠ 4 TRỤ CỘT OOP & 5 NGUYÊN LÝ SOLID
-----------------------------------------------------------------------------
- ĐÓNG GÓI (Encapsulation): ContainerInfo tự kiểm tra mã cont, bảo vệ cờ IsCustomsCleared.
- KẾ THỪA (Inheritance): HQ13 và HQ13A kế thừa 100% giao diện và luồng xử lý từ HQ13Base.
- ĐA HÌNH (Polymorphism): virtual/override GetCustom() biến đổi câu thông báo lúc runtime giữa HQ13 và HQ13A.
- TRỪU TƯỢNG (Abstraction): Form chỉ nói chuyện qua Interface (ICustomsService, INotificationChannel).
- [S] Single Responsibility: Tách riêng Model, Service hải quan, Notification, Form UI.
- [O] Open/Closed: Mở rộng sang HQ13A (có thêm ISO) mà KHÔNG sửa 1 dòng code cũ nào trong HQ13Base hay HQ13.
- [L] Liskov Substitution: HQ13A thay thế HQ13Base hoàn hảo, không làm thay đổi tính đúng đắn logic của cha.
- [I] Interface Segregation: Tách các interface nhỏ gọn, độc lập; không ép class dùng hàm thừa.
- [D] Dependency Inversion: HQ13Base phụ thuộc vào abstraction (ICustomsService, INotificationChannel).
