using BL;
using Persistence;

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.Write("Nhập Tên Đăng Nhập: ");
string acc_name = Console.ReadLine();
Console.Write("Nhập Mật Khẩu: ");
string acc_pass = Console.ReadLine();

AccountBL accountBL = new AccountBL();

Account acc =  accountBL.GetAccountByName(acc_name);

if (acc != null)
{
    if (acc_pass == acc.AccountPassword)
    {
        Console.WriteLine($"Đăng nhập thành công");
    }
    else
    {
        Console.WriteLine($"Sai mật khẩu");
    }
}
else
{
    Console.WriteLine($"Tài khoản không tồn tại");
}