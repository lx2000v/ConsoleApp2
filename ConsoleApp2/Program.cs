using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2//test
{
    public class Initializer : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context context)
        {
            //aaaaaa
            context.PayWays.AddRange(new List<PayWay>
        {
            new PayWay{Name = "支付宝"},
            new PayWay{Name = "微信"},
            new PayWay{Name = "QQ红包"}
        });
        }
    }
    public class Donator
    {
        public int DonatorId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime DonateDate { get; set; }
    }

    public class PayWay
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Context : DbContext
    {
        public Context()
            : base("name=FirstCodeFirstApp")
        {
        }

        public DbSet<PayWay> PayWays { get; set; }

        public DbSet<Donator> Donators { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Database.SetInitializer(new Initializer());

            //using (var context = new Context())
            //{
            //    context.Database.CreateIfNotExists();//如果数据库不存在时则创建

            //    //#region 创建记录
            //    //var donators = new List<Donator>
            //    //{
            //    //    new Donator
            //    //    {
            //    //      Name   = "陈志康",
            //    //      Amount = 50,
            //    //      DonateDate = new DateTime(2016, 4, 7)
            //    //    },
            //    //    new Donator
            //    //    {
            //    //        Name = "海风",
            //    //        Amount = 5,
            //    //        DonateDate = new DateTime(2016, 4, 8)
            //    //    },
            //    //    new Donator
            //    //    {
            //    //        Name = "醉千秋",
            //    //        Amount = 18.8m,
            //    //        DonateDate = new DateTime(2016, 4, 15)
            //    //    }
            //    //};

            //    //context.Donators.AddRange(donators);
            //    //context.SaveChanges();
            //    //#endregion

            //    //#region 2.0 查询记录

            //    //var donators = context.Donators;
            //    //Console.WriteLine("Id\t\t姓名\t\t金额\t\t赞助日期");
            //    //foreach (var donator in donators)
            //    //{
            //    //    Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", donator.DonatorId, donator.Name, donator.Amount, donator.DonateDate.ToShortDateString());
            //    //}
            //    //#endregion

            //    //#region 3.0 更新记录

            //    //var donators = context.Donators;
            //    //if (donators.Any())
            //    //{
            //    //    var toBeUpdatedDonator = donators.First(d => d.Name == "醉千秋");
            //    //    toBeUpdatedDonator.Name = "醉、千秋";
            //    //    context.SaveChanges();
            //    //}

            //    //#endregion

            //    #region 4.0 删除记录

            //    //var toBeDeletedDonator = context.Donators.Single(d => d.Name == "醉、千秋");//根据Name找到要删除的测试数据
            //    //if (toBeDeletedDonator != null)
            //    //{
            //    //    context.Donators.Remove(toBeDeletedDonator);//如果满足条件，就将该对象使用Remove方法标记为Deleted
            //    //    context.SaveChanges();//最后持久化到数据库
            //    //}

            //    #endregion


            //}
            //Console.Write("DB has Created!");//提示DB创建成功
            //Console.Write("Creation Finished!");//提示创建完成
            Console.Read();

        }
    }
}
