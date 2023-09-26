using System;
using System.Data;

namespace ADO
{
    class DisconectedAdo
    {
        public DataTable dt; // Це для таблиць
        public DataColumn dc; // це для атрибутів
        public DataRow dr; // Це для ініціалізації таблиць
        public DataTable GetEquipmentTable()
        {
            dt = new DataTable("Спорядження"); // роблю таблицю
            dc = new DataColumn("ID", typeof(int)); //додаю перший атрибут
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc }; // роблю його первинним ключем

            dc = new DataColumn("Name", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("Quantity", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("Manufacturer", typeof(string));
            dt.Columns.Add(dc);

            dr = dt.NewRow(); // Додаю інші атрибути

            dr[0] = 1; 
            dr[1] = "Шприц";
            dr[2] = 100;
            dr[3] = "МедПласт";

            dt.Rows.Add(dr); // Приклад заповнення таблиці

            dr = dt.NewRow();

            dr[0] = 2;
            dr[1] = "Томограф МРТ";
            dr[2] = 1;
            dr[3] = "MR United";

            dt.Rows.Add(dr);

            dt.Rows.Add(3, "Пульсоксиметр", 10, "OSD"); // Другий приклад заповнення таблиці
            dt.Rows.Add(4, "Дефибрилятор", 5, "Praimed");
            dt.Rows.Add(5, "Стетоскоп", 15, "WBI");


            return dt;
        }
        public DataTable GetMedicineTable()
        {
            DataTable dt = new DataTable("Ліки");

            DataColumn dc = new DataColumn("ID", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("Name", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("Producer", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("Created Date", typeof(DateOnly));
            dt.Columns.Add(dc);

            dc = new DataColumn("Expiration Date", typeof(DateOnly));
            dt.Columns.Add(dc);

            DateOnly date1 = new DateOnly(2023, 05, 05); DateOnly date2 = new DateOnly(2026, 05, 05);
            dt.Rows.Add(1, "Фітотроп", "MedMax", date1, date2);

            date1 = new DateOnly(2023, 02, 02); date2 = new DateOnly(2026, 02, 02);
            dt.Rows.Add(2, "Кромофарм", "ФармаК", date1, date2);

            date1 = new DateOnly(2021, 12, 25); date2 = new DateOnly(2023, 12, 25);
            dt.Rows.Add(3, "Тантум Верде", "А.К.Р.А.Ф", date1, date2);

            date1 = new DateOnly(2021, 08, 11); date2 = new DateOnly(2023, 08, 11);
            dt.Rows.Add(4, "Називін", "Dr.Reddy's", date1, date2);

            date1 = new DateOnly(2022, 12, 10); date2 = new DateOnly(2024, 12, 10);
            dt.Rows.Add(5, "Біле Вугілля", "Борщагівський ХФЗ", date1, date2);


            return dt;
        }
        public DataTable GetPatientTable()
        {
            dt = new DataTable("Пацієнти");

            dc = new DataColumn("ID", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dc = new DataColumn("FirstName", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("LastName", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("MiddleName", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("Age", typeof(int));
            dt.Columns.Add(dc);

            dc = new DataColumn("Disease", typeof(string));
            dt.Columns.Add(dc);

            dc = new DataColumn("ArrivalDate", typeof(DateOnly));
            dt.Columns.Add(dc);

            dc = new DataColumn("DischargeDate", typeof(DateOnly));
            dt.Columns.Add(dc);

            dc = new DataColumn("Ward", typeof(string));
            dt.Columns.Add(dc);



            DateOnly date1 = new DateOnly(2023, 08, 10); DateOnly date2 = new DateOnly(2023, 08, 24);
            dt.Rows.Add(1, "Олена", "Іванов", "Михайлівна", 21, "Грип", date1, date2, "Отоларингологічне відділення");

            date1 = new DateOnly(2023, 07, 12); date2 = new DateOnly(2026, 08, 13);
            dt.Rows.Add(2, "Андрій", "Петров", "Володимирович", 28, "Корона-вірус", date1, date2, "Отоларингологічне відділення");

            date1 = new DateOnly(2023, 09, 02); date2 = new DateOnly(1111, 1, 1);
            dt.Rows.Add(3, "Марія", "Сидоренко", "Петрівна", 19, "Сколіоз", date1, date2, "Ортопедичне відділення");

            date1 = new DateOnly(2023, 08, 25); date2 = new DateOnly(1111, 1, 1);
            dt.Rows.Add(4, "Володимир", "Ковальчук", "Ігорович", 15, "Перелом", date1, date2, "Ортопедичне відділення");

            date1 = new DateOnly(2023, 07, 15); date2 = new DateOnly(2023, 08, 01);
            dt.Rows.Add(5, "Лариса", "Григоренко", "Олександрівна", 25, "Цироз печінки", date1, date2, "Гастроентерологічне відділення");

            return dt;
        }
        public DataTable GetStaffTable()
        {
            dt = new DataTable("Персонал");
            dc = new DataColumn("ID", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("MiddleName", typeof(string));

            dt.Columns.Add("Age", typeof(int));

            dt.Columns.Add("Position", typeof(string));

            dt.Rows.Add(1, "Михайло", "Зубенко", "Петрович", 45, "Хірург");
            dt.Rows.Add(2, "Любомир", "Недзь", "Сергійович", 30, "Сімейний лікар");
            dt.Rows.Add(3, "Оксана", "Балдур", "Михайлівна", 20, "Медсестра");
            dt.Rows.Add(4, "Михайло", "Щурич", "Ігорович", 30, "Оториноларинголог");
            dt.Rows.Add(5, "Софія", "Чупляк", "Романівна", 61, "Терапевт");


            return dt;
        }
        public DataTable GetProceduresTable()
        {
            DataTable dt = new DataTable("Процедури");
            dc = new DataColumn("ProcedureID", typeof(int));
            dt.Columns.Add(dc);
            dt.PrimaryKey = new DataColumn[] { dc };

            dt.Columns.Add("PatientID", typeof(int));
            dt.Columns.Add("EquipmentID", typeof(int));
            dt.Columns.Add("StaffID", typeof(int));
            dt.Columns.Add("MedID", typeof(int));

            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Price", typeof(int));

            dt.Rows.Add(1, 3, 1, 1, 1, "Щоранкові процедури", 50);
            dt.Rows.Add(2,2,5,2,5, "Введення противірусної сироватки",75);
            dt.Rows.Add(3,1,5,4,2, "Встановлення катетора",100);
            dt.Rows.Add(4,5,5,2,3, "Щоранкові процедури",50);
            dt.Rows.Add(5,4,1,1,5, "Взяття крові з пальця",50);

            return dt;
        }
        public DataSet GenerateDataSet()
        {
            DataTable Equip = GetEquipmentTable();  // Тут я читаю всі створені таблиці
            DataTable Medicine = GetMedicineTable();
            DataTable Patients = GetPatientTable();
            DataTable Staff = GetStaffTable();
            DataTable Procedures = GetProceduresTable();

            DataSet ds = new DataSet("MyDS"); // Створюю датасет і додаю всі таблиці в нього
            ds.Tables.Add(Equip);
            ds.Tables.Add(Medicine);
            ds.Tables.Add(Patients);
            ds.Tables.Add(Staff);
            ds.Tables.Add(Procedures);
            // Виставляю всі зв'язки між таблицями
            DataRelation proc_pat = new DataRelation("ProcPat", ds.Tables["Пацієнти"].Columns["ID"], ds.Tables["Процедури"].Columns["PatientID"]);
            DataRelation proc_equip = new DataRelation("ProcEquip", ds.Tables["Спорядження"].Columns["ID"], ds.Tables["Процедури"].Columns["EquipmentID"]);
            DataRelation proc_staff = new DataRelation("ProcStaff", ds.Tables["Персонал"].Columns["ID"], ds.Tables["Процедури"].Columns["StaffID"]);
            DataRelation proc_med = new DataRelation("ProcMed", ds.Tables["Ліки"].Columns["ID"], ds.Tables["Процедури"].Columns["MedID"]);
            // Зберігаю зв'зки в датасеті 
            ds.Relations.Add(proc_pat);
            ds.Relations.Add(proc_equip);
            ds.Relations.Add(proc_staff);
            ds.Relations.Add(proc_med);

            return ds;
        }
        public static void Display(DataTable dt, DataSet ds)
        {
            Console.WriteLine("Таблиця {0}:", dt.TableName);
            if (dt.TableName != "Процедури" && ds != null) // Вивджу зміст таблиць
            {
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (var item in dr.ItemArray)
                    {
                        Console.Write(item + " ");
                    }
                    Console.WriteLine();
                }
            }
            if (dt.TableName == "Процедури" && ds != null) // Для виводу таблиці Процедури треба дивитись в інші таблиці
            {

                // Отримаю всі релейшини
                DataRelation proc_pat = ds.Relations["ProcPat"];
                DataRelation proc_equip = ds.Relations["ProcEquip"];
                DataRelation proc_staff = ds.Relations["ProcStaff"];
                DataRelation proc_med = ds.Relations["ProcMed"];

                foreach (DataRow dr in dt.Rows)
                {
                    int patientID = (int)dr["PatientID"];
                    int equipmentID = (int)dr["EquipmentID"];
                    int staffID = (int)dr["StaffID"];
                    int medID = (int)dr["MedID"];

                    // Отримую дочірні рядки для кожного ID
                    DataRow[] patients = ds.Tables["Пацієнти"].Select($"ID = {patientID}");
                    DataRow[] equipment = ds.Tables["Спорядження"].Select($"ID = {equipmentID}");
                    DataRow[] staff = ds.Tables["Персонал"].Select($"ID = {staffID}");
                    DataRow[] medicine = ds.Tables["Ліки"].Select($"ID = {medID}");

                    if (patients.Length > 0) // Виводжу дані
                    {
                        Console.WriteLine();
                        Console.Write("Пацієнт: {0} {1} {2} {3}", patients[0].ItemArray[2],patients[0].ItemArray[1], patients[0].ItemArray[3], patients[0].ItemArray[5]);
                        Console.WriteLine();
                    }

                    if (equipment.Length > 0)
                    {
                        Console.Write("Обладнання: {0} {1}", equipment[0].ItemArray[1], equipment[0].ItemArray[3]);
                        Console.WriteLine();
                    }

                    if (staff.Length > 0)
                    {
                        Console.Write("Персонал: {0} {1} {2} {3}", staff[0].ItemArray[2], staff[0].ItemArray[1], staff[0].ItemArray[3], staff[0].ItemArray[5]);
                        Console.WriteLine();
                    }

                    if (medicine.Length > 0)
                    {
                        Console.Write("Ліки: {0} {1} {2} {3}", medicine[0].ItemArray[1], medicine[0].ItemArray[2], medicine[0].ItemArray[3], medicine[0].ItemArray[4]);
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();
        }
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DisconectedAdo a = new DisconectedAdo(); 
            DataSet myds = a.GenerateDataSet();
            Display(myds.Tables["Процедури"],myds);
            Display(myds.Tables["Ліки"],myds);
            Display(myds.Tables["Персонал"],myds);
            Display(myds.Tables["Спорядження"],myds);
            Display(myds.Tables["Пацієнти"],myds);
        }
    }
}