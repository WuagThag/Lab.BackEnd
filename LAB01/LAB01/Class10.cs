using System;
using System.Text;

namespace LAB01
{
    internal class Class10
    {
        public void Run()
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Console.WriteLine("Bài tập 10: Tính giai thừa của một số");

                Console.Write("Nhập một số nguyên không âm: ");
                int n = int.Parse(Console.ReadLine());

                if (n < 0)
                {
                    throw new Exception("Giai thừa không được định nghĩa cho số âm!");
                }

                long giaiThua = TinhGiaiThua(n);
                Console.WriteLine($"Giai thừa của {n} là: {giaiThua}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Lỗi: Vui lòng nhập một số nguyên hợp lệ!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Kết thúc chương trình.");
            }
        }

        private long TinhGiaiThua(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            long ketQua = 1;
            for (int i = 2; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }
    }
}