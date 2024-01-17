//建立計算bmi的類別, 具有身高體重屬性，和一個計算bmi的方法
//屬性: height, weight
//方法: GetBMI
//使用方法: bmi.GetBMI()
namespace webtest
{
    public class Bmi
    {
        public double height { get; set; }
        public double weight { get; set; }

        public double Calculate()
        {
            return weight / (height * height);
        }
    }
}