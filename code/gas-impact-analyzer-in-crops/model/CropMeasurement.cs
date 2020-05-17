namespace model
{
    public class CropMeasurement
    {
        private string municipality;
        private int year;
        private double algodonA;
        private double algodonB;
        private double arrozA;
        private double arrozB;
        private double frijolA;
        private double frijolB;
        private double maizTecnificadoA;
        private double maizTecnificadoB;
        private double sorgoA;
        private double sorgoB;
        private double soyaA;
        private double soyaB;
        private double tabacoA;
        private double tabacoB;
        private double maizTradicionalA;
        private double maizTradicionalB;

        public CropMeasurement(string municipality, int year, double algodonA, double algodonB, double arrozA, double arrozB, double frijolA, double frijolB, double maizTecnificadoA, double maizTecnificadoB, double sorgoA, double sorgoB, double soyaA, double soyaB, double tabacoA, double tabacoB, double maizTradicionalA, double maizTradicionalB)
        {
            this.Municipality = municipality;
            this.Year = year;
            this.AlgodonA = algodonA;
            this.AlgodonB = algodonB;
            this.ArrozA = arrozA;
            this.ArrozB = arrozB;
            this.FrijolA = frijolA;
            this.FrijolB = frijolB;
            this.MaizTecnificadoA = maizTecnificadoA;
            this.MaizTecnificadoB = maizTecnificadoB;
            this.SorgoA = sorgoA;
            this.SorgoB = sorgoB;
            this.SoyaA = soyaA;
            this.SoyaB = soyaB;
            this.TabacoA = tabacoA;
            this.TabacoB = tabacoB;
            this.MaizTradicionalA = maizTradicionalA;
            this.MaizTradicionalB = maizTradicionalB;
        }
        public double getTypeCrop(string crop)
        {
            double ans = 0.0;
            if (crop == "AlgodonA") ans = this.AlgodonA;
            else if (crop == "AlgodonB") ans = this.AlgodonB;
            else if (crop == "ArrozA") ans = this.ArrozA;
            else if (crop == "ArrozB") ans = this.ArrozB;
            else if (crop == "FrijolA") ans = this.FrijolA;
            else if (crop == "FrijolB") ans = this.FrijolB;
            else if (crop == "MaizTecnificadoA") ans = this.MaizTecnificadoA;
            else if (crop == "MaizTecnificadoB") ans = this.MaizTecnificadoB;
            else if (crop == "SorgoA") ans = this.SorgoA;
            else if (crop == "SorgoB") ans = this.SorgoB;
            else if (crop == "SoyaA") ans = this.SoyaA;
            else if (crop == "SoyaB") ans = this.SoyaB;
            else if (crop == "TabacoA") ans = this.TabacoA;
            else if (crop == "TabacoB") ans = this.TabacoB;
            else if (crop == "MaizTradicionalA") ans = this.MaizTradicionalA;
            else if (crop == "MaizTradicionalB") ans = this.MaizTradicionalB;
            return ans;

        }
        public string Municipality { get => municipality; set => municipality = value; }
        public int Year { get => year; set => year = value; }
        public double AlgodonA { get => algodonA; set => algodonA = value; }
        public double AlgodonB { get => algodonB; set => algodonB = value; }
        public double ArrozA { get => arrozA; set => arrozA = value; }
        public double ArrozB { get => arrozB; set => arrozB = value; }
        public double FrijolA { get => frijolA; set => frijolA = value; }
        public double FrijolB { get => frijolB; set => frijolB = value; }
        public double MaizTecnificadoA { get => maizTecnificadoA; set => maizTecnificadoA = value; }
        public double MaizTecnificadoB { get => maizTecnificadoB; set => maizTecnificadoB = value; }
        public double SorgoA { get => sorgoA; set => sorgoA = value; }
        public double SorgoB { get => sorgoB; set => sorgoB = value; }
        public double SoyaA { get => soyaA; set => soyaA = value; }
        public double SoyaB { get => soyaB; set => soyaB = value; }
        public double TabacoA { get => tabacoA; set => tabacoA = value; }
        public double TabacoB { get => tabacoB; set => tabacoB = value; }
        public double MaizTradicionalA { get => maizTradicionalA; set => maizTradicionalA = value; }
        public double MaizTradicionalB { get => maizTradicionalB; set => maizTradicionalB = value; }
    }
}