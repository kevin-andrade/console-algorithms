using System.Globalization;

namespace Employee
{
    public class Employee {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary () {
            return GrossSalary -= Tax;
        }

        public void IncreaseSalary (double percent) {
            GrossSalary = GrossSalary + (GrossSalary * percent / 100.0);
        }

        public override string ToString() {
            return Name
                + ", "
                + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
