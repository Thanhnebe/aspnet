using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    // GET: /Account/Login
    public IActionResult Login()
    {
        return View();
    }

    // POST: /Account/Login
    [HttpPost]
    public IActionResult Login(string username, string password)
    {
        // Xử lý đăng nhập ở đây (kiểm tra username/password với cơ sở dữ liệu, session, cookie, ...)
        // Ví dụ đơn giản, chuyển hướng đến trang chủ nếu đăng nhập thành công
        // Hoặc hiển thị thông báo lỗi nếu đăng nhập không thành công

        // Ví dụ đơn giản chuyển hướng đến trang chủ
        return RedirectToAction("Index", "Home");
    }
}
