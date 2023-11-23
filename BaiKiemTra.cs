using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapMangArrays
{
    public class BaiKiemTra
    {
        public List<int> DaySo { get; set; }
        public string ChuyenSoThanhChu(int n)
        {
            DaySo = new List<int>();
            string ketqua = "Chưa có kết quả";
            if (n >= 1000 || n < 0)
            {
                return "Chỉ nhập số từ 1 đến nhỏ hơn 1000";
            }
            else if (n == 0)
            {
                return "Không";
            }
            else
            {

                while (n != 0)
                {
                    int SoNguyen = n % 10;
                    n = n / 10;
                    DaySo.Add(SoNguyen);
                }
                DocSoDonVi docsoDonVi = new DocSoDonVi();
                DocSoHangChuc docSoHangChuc = new DocSoHangChuc();
                DocSoHangTram docSoHangTram = new DocSoHangTram();
                if (DaySo.Count == 1)
                {
                    return docsoDonVi.XuatSoRaChu(DaySo[0]);
                }
                else if (DaySo.Count == 2)
                {
                    if (DaySo[1] == 1 && DaySo[0] == 0)
                    {
                        return "Mười";
                    }
                    else if (DaySo[1] != 0 && DaySo[0] == 0)
                    {
                        return $"{docSoHangChuc.XuatSoRaChu(DaySo[1])} Mươi";

                    }
                    else if (DaySo[0] != 0 && DaySo[1] == 1)
                    {
                        return $"{docSoHangChuc.XuatSoRaChu(DaySo[1])} {docsoDonVi.XuatSoRaChu(DaySo[0])}";
                    }
                    else if (DaySo[0] == 1 && DaySo[1] != 0 && DaySo[1] != 1)
                    {
                        return $"{docSoHangChuc.XuatSoRaChu(DaySo[1])} Mươi Mốt";
                    }

                    return $"{docSoHangChuc.XuatSoRaChu(DaySo[1])} Mươi {docsoDonVi.XuatSoRaChu(DaySo[0])}";

                }
                else if (DaySo.Count == 3)
                {
                    if (DaySo[0] == 0 && DaySo[1] == 0)
                    {
                        return $"{docSoHangTram.XuatSoRaChu(DaySo[2])} Trăm";
                    }
                    else if (DaySo[1] == 0 && DaySo[0] != 0)
                    {
                        return $"{docSoHangTram.XuatSoRaChu(DaySo[2])} Trăm Linh {docsoDonVi.XuatSoRaChu(DaySo[0])}";
                    }
                    else if (DaySo[0] == 0 && DaySo[1] == 1)
                    {
                        return $"{docSoHangTram.XuatSoRaChu(DaySo[2])} Trăm Mười";
                    }

                    else if (DaySo[0] != 0 && DaySo[1] == 1)
                    {
                        return $"{docSoHangTram.XuatSoRaChu(DaySo[2])} Trăm Mười {docsoDonVi.XuatSoRaChu(DaySo[0])}";
                    }
                    else if (DaySo[0] == 0 && DaySo[1] != 1 && DaySo[1] != 0)
                    {
                        return $"{docSoHangTram.XuatSoRaChu(DaySo[2])} Trăm {docSoHangChuc.XuatSoRaChu(DaySo[1])} Mươi ";
                    }

                    else if (DaySo[0] == 1 && DaySo[1] != 0)
                    {
                        return $"{docSoHangTram.XuatSoRaChu(DaySo[2])} Trăm {docSoHangChuc.XuatSoRaChu(DaySo[1])} Mươi Mốt";
                    }
                    else
                    {
                        return $"{docSoHangTram.XuatSoRaChu(DaySo[2])} Trăm {docSoHangChuc.XuatSoRaChu(DaySo[1])} Mươi {docsoDonVi.XuatSoRaChu(DaySo[0])}";
                    }

                }
                else
                {
                    return null;
                }

            }
        }

    }
    public class DocSoDonVi
    {
        public virtual string XuatSoRaChu(int DonVi)
        {
            if (DonVi == 0)
            {
                return "Không";
            }
            else if (DonVi == 1)
            {
                return "Một";
            }
            else if (DonVi == 2)
            {
                return "Hai";
            }
            else if (DonVi == 3)
            {
                return "Ba";
            }
            else if (DonVi == 4)
            {
                return "Bốn";
            }
            else if (DonVi == 5)
            {
                return "Năm";
            }
            else if (DonVi == 6)
            {
                return "Sáu";
            }
            else if (DonVi == 7)
            {
                return "Bảy";
            }
            else if (DonVi == 8)
            {
                return "Tám";
            }
            else if (DonVi == 9)
            {
                return "Chín";
            }
            else
            {
                return "Error";
            }
        }

    }
    public class DocSoHangChuc : DocSoDonVi
    {
        public override string XuatSoRaChu(int DonVi)
        {
            if (DonVi == 1)
            {
                return "Mười";

            }


            else
            {
                return base.XuatSoRaChu(DonVi);
            }


        }
    }
    public class DocSoHangTram : DocSoDonVi
    {
        public override string XuatSoRaChu(int DonVi)
        {
            return base.XuatSoRaChu(DonVi);
        }
    }
}
