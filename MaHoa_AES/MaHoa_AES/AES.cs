using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaHoa_AES
{
    class AES
    {

        public static String[,] sbox = {
            {"63","7c","77","7b","f2","6b","6f","c5","30","01","67","2b","fe","d7","ab","76"},
            {"ca","82","c9","7d","fa","59","47","f0","ad","d4","a2","af","9c","a4","72","c0"},
            {"b7","fd","93","26","36","3f","f7","cc","34","a5","e5","f1","71","d8","31","15"},
            {"04","c7","23","c3","18","96","05","9a","07","12","80","e2","eb","27","b2","75"},
            {"09","83","2c","1a","1b","6e","5a","a0","52","3b","d6","b3","29","e3","2f","84"},
            {"53","d1","00","ed","20","fc","b1","5b","6a","cb","be","39","4a","4c","58","cf"},
            {"d0","ef","aa","fb","43","4d","33","85","45","f9","02","7f","50","3c","9f","a8"},
            {"51","a3","40","8f","92","9d","38","f5","bc","b6","da","21","10","ff","f3","d2"},
            {"cd","0c","13","ec","5f","97","44","17","c4","a7","7e","3d","64","5d","19","73"},
            {"60","81","4f","dc","22","2a","90","88","46","ee","b8","14","de","5e","0b","db"},
            {"e0","32","3a","0a","49","06","24","5c","c2","d3","ac","62","91","95","e4","79"},
            {"e7","c8","37","6d","8d","d5","4e","a9","6c","56","f4","ea","65","7a","ae","08"},
            {"ba","78","25","2e","1c","a6","b4","c6","e8","dd","74","1f","4b","bd","8b","8a"},
            {"70","3e","b5","66","48","03","f6","0e","61","35","57","b9","86","c1","1d","9e"},
            {"e1","f8","98","11","69","d9","8e","94","9b","1e","87","e9","ce","55","28","df"},
            {"8c","a1","89","0d","bf","e6","42","68","41","99","2d","0f","b0","54","bb","16"}};

        public static String[,] invsbox = {
            {"52", "09", "6a", "d5", "30", "36", "a5", "38", "bf", "40", "a3", "9e", "81", "f3", "d7", "fb"},
            {"7c", "e3", "39", "82", "9b", "2f", "ff", "87", "34", "8e", "43", "44", "c4", "de", "e9", "cb"},
            {"54", "7b", "94", "32", "a6", "c2", "23", "3d", "ee", "4c", "95", "0b", "42", "fa", "c3", "4e"},
            {"08", "2e", "a1", "66", "28", "d9", "24", "b2", "76", "5b", "a2", "49", "6d", "8b", "d1", "25"},
            {"72", "f8", "f6", "64", "86", "68", "98", "16", "d4", "a4", "5c", "cc", "5d", "65", "b6", "92"},
            {"6c", "70", "48", "50", "fd", "ed", "b9", "da", "5e", "15", "46", "57", "a7", "8d", "9d", "84"},
            {"90", "d8", "ab", "00", "8c", "bc", "d3", "0a", "f7", "e4", "58", "05", "b8", "b3", "45", "06"},
            {"d0", "2c", "1e", "8f", "ca", "3f", "0f", "02", "c1", "af", "bd", "03", "01", "13", "8a", "6b"},
            {"3a", "91", "11", "41", "4f", "67", "dc", "ea", "97", "f2", "cf", "ce", "f0", "b4", "e6", "73"},
            {"96", "ac", "74", "22", "e7", "ad", "35", "85", "e2", "f9", "37", "e8", "1c", "75", "df", "6e"},
            {"47", "f1", "1a", "71", "1d", "29", "c5", "89", "6f", "b7", "62", "0e", "aa", "18", "be", "1b"},
            {"fc", "56", "3e", "4b", "c6", "d2", "79", "20", "9a", "db", "c0", "fe", "78", "cd", "5a", "f4"},
            {"1f", "dd", "a8", "33", "88", "07", "c7", "31", "b1", "12", "10", "59", "27", "80", "ec", "5f"},
            {"60", "51", "7f", "a9", "19", "b5", "4a", "0d", "2d", "e5", "7a", "9f", "93", "c9", "9c", "ef"},
            {"a0", "e0", "3b", "4d", "ae", "2a", "f5", "b0", "c8", "eb", "bb", "3c", "83", "53" ,"99", "61"},
            {"17", "2b", "04", "7e", "ba", "77", "d6", "26", "e1", "69", "14", "63", "55", "21" ,"0c", "7d"}};

        public static String[,] matranbd = {
                                        {"02","03","01","01"},
                                        {"01","02","03","01"},
                                        {"01","01","02","03"},
                                        {"03","01","01","02"}
                                    };

        public static String[,] invmatranbd = {
            {"0e","0b","0d","09"},
            {"09","0e","0b","0d"},
            {"0d","09","0e","0b"},
            {"0b","0d","09","0e"}
        };


        public static String[] R_con_1 = { "01", "00", "00", "00" };
        public static String[] R_con_2 = { "02", "00", "00", "00" };
        public static String[] R_con_3 = { "04", "00", "00", "00" };
        public static String[] R_con_4 = { "08", "00", "00", "00" };
        public static String[] R_con_5 = { "10", "00", "00", "00" };
        public static String[] R_con_6 = { "20", "00", "00", "00" };
        public static String[] R_con_7 = { "40", "00", "00", "00" };
        public static String[] R_con_8 = { "80", "00", "00", "00" };
        public static String[] R_con_9 = { "1b", "00", "00", "00" };
        public static String[] R_con_10 = { "36", "00", "00", "00" };

        public static int[] churanhiphan(char so)
        {
            int[] sday = new int[4];
            if (so == '0')
            {
                sday[0] = 0;
                sday[1] = 0;
                sday[2] = 0;
                sday[3] = 0;
            }
            else if (so == '1')
            {
                sday[0] = 0;
                sday[1] = 0;
                sday[2] = 0;
                sday[3] = 1;
            }
            else if (so == '2')
            {
                sday[0] = 0;
                sday[1] = 0;
                sday[2] = 1;
                sday[3] = 0;
            }
            else if (so == '3')
            {
                sday[0] = 0;
                sday[1] = 0;
                sday[2] = 1;
                sday[3] = 1;
            }
            else if (so == '4')
            {
                sday[0] = 0;
                sday[1] = 1;
                sday[2] = 0;
                sday[3] = 0;
            }
            else if (so == '5')
            {
                sday[0] = 0;
                sday[1] = 1;
                sday[2] = 0;
                sday[3] = 1;
            }
            else if (so == '6')
            {
                sday[0] = 0;
                sday[1] = 1;
                sday[2] = 1;
                sday[3] = 0;
            }
            else if (so == '7')
            {
                sday[0] = 0;
                sday[1] = 1;
                sday[2] = 1;
                sday[3] = 1;
            }
            else if (so == '8')
            {
                sday[0] = 1;
                sday[1] = 0;
                sday[2] = 0;
                sday[3] = 0;
            }
            else if (so == '9')
            {
                sday[0] = 1;
                sday[1] = 0;
                sday[2] = 0;
                sday[3] = 1;
            }
            else if (so == 'a')
            {
                sday[0] = 1;
                sday[1] = 0;
                sday[2] = 1;
                sday[3] = 0;
            }
            else if (so == 'b')
            {
                sday[0] = 1;
                sday[1] = 0;
                sday[2] = 1;
                sday[3] = 1;
            }
            else if (so == 'c')
            {
                sday[0] = 1;
                sday[1] = 1;
                sday[2] = 0;
                sday[3] = 0;
            }
            else if (so == 'd')
            {
                sday[0] = 1;
                sday[1] = 1;
                sday[2] = 0;
                sday[3] = 1;
            }
            else if (so == 'e')
            {
                sday[0] = 1;
                sday[1] = 1;
                sday[2] = 1;
                sday[3] = 0;
            }
            else if (so == 'f')
            {
                sday[0] = 1;
                sday[1] = 1;
                sday[2] = 1;
                sday[3] = 1;
            }
            return sday;
        }
        public static int[] XOR(int[] so1, int[] so2)
        {
            int[] kq = new int[4];
            for (int i = 0; i <= 3; i++)
            {
                if (so1[i] == so2[i])
                {
                    kq[i] = 0;
                }
                else
                {
                    kq[i] = 1;
                }
            }
            return kq;
        }
        public static int Tinhnp(int[] day)
        {
            return day[0] * 8 + day[1] * 4 + day[2] * 2 + day[3] * 1;
        }
        public static String kytu(int[] day)
        {
            if (Tinhnp(day) < 10) return "" + Tinhnp(day);
            else if (Tinhnp(day) == 10) return "a";
            else if (Tinhnp(day) == 11) return "b";
            else if (Tinhnp(day) == 12) return "c";
            else if (Tinhnp(day) == 13) return "d";
            else if (Tinhnp(day) == 14) return "e";
            else return "f";

        }
        public static String doi2kytu(int[] day)
        {
            String kq = "";
            int[] day1 = new int[4];
            int[] day2 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                day1[i] = day[i];
            }
            kq += kytu(day1);
            for (int i = 4; i < 8; i++)
            {
                day2[i - 4] = day[i];
            }
            kq = kq + kytu(day2);
            return kq;
        }
        public static int chuyen16sangso(char so16)
        {
            return Tinhnp(churanhiphan(so16));
        }
        public static String XOR16(String so1, String so2)
        {
            String kq = "";

            for (int i = 0; i < so1.Length; i++)
            {

                int[] daykytuso1 = churanhiphan(so1[i]);
                int[] daykytuso2 = churanhiphan(so2[i]);
                int[] kqkytu = XOR(daykytuso1, daykytuso2);
                kq = kq + kytu(kqkytu);
            }
            return kq;
        }
        public static int[] DichTraiBit(int[] day)
        {
            int[] KQ = new int[day.Length];
            int tam = 0;

            tam = day[0];
            for (int j = 0; j < day.Length - 1; j++)
            {
                KQ[j] = day[j + 1];
            }
            KQ[day.Length - 1] = 0;

            return KQ;
        }

        public static int[] cong2day(int[] day1, int[] day2)
        {
            int[] kq = new int[day1.Length + day2.Length];
            for (int i = 0; i < day1.Length; i++)
            {
                kq[i] = day1[i];
            }
            for (int i = day1.Length; i < day1.Length + day2.Length; i++)
            {
                kq[i] = day2[i - day1.Length];
            }

            return kq;
        }

        public static String nhanvs02(String kq, int[] day)
        {
            if (day[0] == 1)
            {
                day = DichTraiBit(day);
                kq = doi2kytu(day);
                kq = XOR16(kq, "1b");
            }
            else if (day[0] == 0)
            {
                day = DichTraiBit(day);

                kq = doi2kytu(day);

            }
            return kq;
        }


        public static String nhanbangbd(String so, String bbd)
        {
            String kq = "";
            if (bbd == "01")
            {
                kq = so;
            }
            else if (bbd == "02")
            {
                int[] day = new int[8];

                day = cong2day(churanhiphan(so[0]), churanhiphan(so[1]));

                kq = nhanvs02(kq,day);


            }
            else if (bbd == "03")
            {
                int[] day = new int[8];
                day = cong2day(churanhiphan(so[0]), churanhiphan(so[1]));
                kq = nhanvs02(kq, day);
                kq = XOR16(so, kq);
            }
            return kq;
        }


        public static String nhanbanginvbd(String so, String binvbd)
        {
            String kq = "";
            if (binvbd == "0e")
            {
                int[] day = new int[8];
                day = cong2day(churanhiphan(so[0]), churanhiphan(so[1]));
                int[] daysaunhan02lan1 = new int[8];
                daysaunhan02lan1 = cong2day(churanhiphan(nhanvs02(kq, day)[0]), churanhiphan(nhanvs02(kq, day)[1]));
                int[] daysaunhan02lan2 = new int[8];
                daysaunhan02lan2 = cong2day(churanhiphan(nhanvs02(kq, daysaunhan02lan1)[0]), churanhiphan(nhanvs02(kq, daysaunhan02lan1)[1]));
                int[] daysaunhan02lan3 = new int[8];
                daysaunhan02lan3 = cong2day(churanhiphan(nhanvs02(kq, daysaunhan02lan2)[0]), churanhiphan(nhanvs02(kq, daysaunhan02lan2)[1]));

                kq = XOR16voi3kytu(doi2kytu(daysaunhan02lan3), doi2kytu(daysaunhan02lan2), doi2kytu(daysaunhan02lan1));

            }
            else if (binvbd == "0b")
            {
                int[] day = new int[8];
                day = cong2day(churanhiphan(so[0]), churanhiphan(so[1]));
                int[] daysaunhan02lan1 = new int[8];
                daysaunhan02lan1 = cong2day(churanhiphan(nhanvs02(kq, day)[0]), churanhiphan(nhanvs02(kq, day)[1]));
                int[] daysaunhan02lan2 = new int[8];
                daysaunhan02lan2 = cong2day(churanhiphan(nhanvs02(kq, daysaunhan02lan1)[0]), churanhiphan(nhanvs02(kq, daysaunhan02lan1)[1]));
                int[] daysaunhan02lan3 = new int[8];
                daysaunhan02lan3 = cong2day(churanhiphan(nhanvs02(kq, daysaunhan02lan2)[0]), churanhiphan(nhanvs02(kq, daysaunhan02lan2)[1]));

                kq = XOR16voi3kytu(doi2kytu(daysaunhan02lan3), doi2kytu(daysaunhan02lan1), so);

            }
            else if (binvbd == "0d")
            {
                int[] day = new int[8];
                day = cong2day(churanhiphan(so[0]), churanhiphan(so[1]));
                int[] daysaunhan02lan1 = new int[8];
                daysaunhan02lan1 = cong2day(churanhiphan(nhanvs02(kq, day)[0]), churanhiphan(nhanvs02(kq, day)[1]));
                int[] daysaunhan02lan2 = new int[8];
                daysaunhan02lan2 = cong2day(churanhiphan(nhanvs02(kq, daysaunhan02lan1)[0]), churanhiphan(nhanvs02(kq, daysaunhan02lan1)[1]));
                int[] daysaunhan02lan3 = new int[8];
                daysaunhan02lan3 = cong2day(churanhiphan(nhanvs02(kq, daysaunhan02lan2)[0]), churanhiphan(nhanvs02(kq, daysaunhan02lan2)[1]));

                kq = XOR16voi3kytu(doi2kytu(daysaunhan02lan3), doi2kytu(daysaunhan02lan2), so);

            }else if (binvbd == "09")
            {
                int[] day = new int[8];
                day = cong2day(churanhiphan(so[0]), churanhiphan(so[1]));
                int[] daysaunhan02lan1 = new int[8];
                daysaunhan02lan1 = cong2day(churanhiphan(nhanvs02(kq, day)[0]), churanhiphan(nhanvs02(kq, day)[1]));
                int[] daysaunhan02lan2 = new int[8];
                daysaunhan02lan2 = cong2day(churanhiphan(nhanvs02(kq, daysaunhan02lan1)[0]), churanhiphan(nhanvs02(kq, daysaunhan02lan1)[1]));
                int[] daysaunhan02lan3 = new int[8];
                daysaunhan02lan3 = cong2day(churanhiphan(nhanvs02(kq, daysaunhan02lan2)[0]), churanhiphan(nhanvs02(kq, daysaunhan02lan2)[1]));

                kq = XOR16(doi2kytu(daysaunhan02lan3),so);
            }
            return kq;
        }

        
            public static String XOR16voi4kytu(String so1, String so2, String so3, String so4)
        {
            String kq;
            kq = XOR16(so1, so2);
            kq = XOR16(kq, so3);
            kq = XOR16(kq, so4);
            return kq;
        }
        public static String XOR16voi3kytu(String so1, String so2, String so3)
        {
            String kq;
            kq = XOR16(so1, so2);
            kq = XOR16(kq, so3);

            return kq;
        }
        public static String[] layR_con(int so)
        {
            String[] kq = new String[4];
            if (so == 1)
            {
                kq = R_con_1;
            }
            else if (so == 2)
            {
                kq = R_con_2;
            }
            else if (so == 3)
            {
                kq = R_con_3;
            }
            else if (so == 4)
            {
                kq = R_con_4;
            }
            else if (so == 5)
            {
                kq = R_con_5;
            }
            else if (so == 6)
            {
                kq = R_con_6;
            }
            else if (so == 7)
            {
                kq = R_con_7;
            }
            else if (so == 8)
            {
                kq = R_con_8;
            }
            else if (so == 9)
            {
                kq = R_con_9;
            }
            else if (so == 10)
            {
                kq = R_con_10;
            }
            return kq;
        }
        public static String[] bdcotcuoicuakhoa(String[] socot)
        {
            //Rotword +SubBytes
            String tg;
            tg = socot[0];
            socot[0] = socot[3];
            socot[3] = tg;

            tg = socot[0];
            socot[0] = socot[2];
            socot[2] = tg;

            tg = socot[0];
            socot[0] = socot[1];
            socot[1] = tg;
            String kytuc4_1 = socot[0];
            String kytuc4_2 = socot[1];
            String kytuc4_3 = socot[2];
            String kytuc4_4 = socot[3];

            socot[0] = sbox[chuyen16sangso(kytuc4_1[0]), chuyen16sangso(kytuc4_1[1])];
            socot[1] = sbox[chuyen16sangso(kytuc4_2[0]), chuyen16sangso(kytuc4_2[1])];
            socot[2] = sbox[chuyen16sangso(kytuc4_3[0]), chuyen16sangso(kytuc4_3[1])];
            socot[3] = sbox[chuyen16sangso(kytuc4_4[0]), chuyen16sangso(kytuc4_4[1])];

            return socot;
        }
        public static String[,] tinhkhoa(String[] R_con, String[,] khoatrc)
        {
            String[,] kq = new String[4, 4];
            String[] cot1 = new String[4];
            String[] cot2 = new String[4];
            String[] cot3 = new String[4];
            String[] cot4cu = new String[4];


            for (int j = 0; j <= 3; j++)
                for (int i = 0; i <= 3; i++)
                {
                    if (j == 0) cot1[i] = khoatrc[i, j];
                    else if (j == 1) cot2[i] = khoatrc[i, j];
                    else if (j == 2) cot3[i] = khoatrc[i, j];
                    else if (j == 3) cot4cu[i] = khoatrc[i, j];
                }
            
            String[] cotmoi = bdcotcuoicuakhoa(cot4cu);

            String[] cot1_new = new String[4];
            String[] cot2_new = new String[4];
            String[] cot3_new = new String[4];
            String[] cot4_new = new String[4];

            //Rcon
            for (int i = 0; i <= 3; i++)
            {
                cot1_new[i] = XOR16voi3kytu(khoatrc[i, 0], cotmoi[i], R_con[i]);
            }
            for (int i = 0; i <= 3; i++)
            {
                cot2_new[i] = XOR16(cot1_new[i], cot2[i]);
            }
            for (int i = 0; i <= 3; i++)
            {
                cot3_new[i] = XOR16(cot2_new[i], cot3[i]);
            }

            for (int i = 0; i <= 3; i++)
            {
                cot4_new[i] = XOR16(cot3_new[i], khoatrc[i, 3]);
            }

            for (int j = 0; j <= 3; j++)
                for (int i = 0; i <= 3; i++)
                {
                    if (j == 0) kq[i, j] = cot1_new[i];
                    else if (j == 1) kq[i, j] = cot2_new[i];
                    else if (j == 2) kq[i, j] = cot3_new[i];
                    else if (j == 3) kq[i, j] = cot4_new[i];
                }
            return kq;
        }
    }

}
