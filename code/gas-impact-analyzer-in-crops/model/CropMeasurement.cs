namespace model
{
    public class CropMeasurement
    {
        private string municipios;
        private int a_o;
        private double algod_n_a;
        private double algod_n_b;
        private double arroz_a;
        private double arroz;
        private double frijol_a;
        private double frijol_b;
        private double ma_z_tecnificado_a;
        private double ma_z_tecnificado_b   ;
        private double sorgo_a;
        private double sorgo_b;
        private double soya_a;
        private double soya_b;
        private double tabaco_a;
        private double tabaco_b;
        private double ma_z_tradicional_a;
        private double ma_z_tradicional_b;

        public CropMeasurement() { }
        public CropMeasurement(string municipality, int year, double algodonA, double algodonB, double arrozA, double arrozB, double frijolA, double frijolB, double maizTecnificadoA, double maizTecnificadoB, double sorgoA, double sorgoB, double soyaA, double soyaB, double tabacoA, double tabacoB, double maizTradicionalA, double maizTradicionalB)
        {
            this.Municipios = municipality;
            this.A_o = year;
            this.Algod_n_a = algodonA;
            this.Algod_n_b = algodonB;
            this.Arroz_a = arrozA;
            this.Arroz = arrozB;
            this.Frijol_a = frijolA;
            this.Frijol_b = frijolB;
            this.Ma_z_tecnificado_a = maizTecnificadoA;
            this.Ma_z_tecnificado_b = maizTecnificadoB;
            this.Sorgo_a = sorgoA;
            this.Sorgo_b = sorgoB;
            this.Soya_a = soyaA;
            this.Soya_b = soyaB;
            this.Tabaco_a = tabacoA;
            this.Tabaco_b = tabacoB;
            this.Ma_z_tradicional_a = maizTradicionalA;
            this.Ma_z_tradicional_b = maizTradicionalB;
        }

        
        public double getTypeCrop(string crop)
        {
            double ans = 0.0;
            if (crop == "AlgodonA") ans = this.Algod_n_a;
            else if (crop == "AlgodonB") ans = this.Algod_n_b;
            else if (crop == "ArrozA") ans = this.Arroz_a;
            else if (crop == "ArrozB") ans = this.Arroz;
            else if (crop == "FrijolA") ans = this.Frijol_a;
            else if (crop == "FrijolB") ans = this.Frijol_b;
            else if (crop == "MaizTecnificadoA") ans = this.Ma_z_tecnificado_a;
            else if (crop == "MaizTecnificadoB") ans = this.Ma_z_tecnificado_b;
            else if (crop == "SorgoA") ans = this.Sorgo_a;
            else if (crop == "SorgoB") ans = this.Sorgo_b;
            else if (crop == "SoyaA") ans = this.Soya_a;
            else if (crop == "SoyaB") ans = this.Soya_b;
            else if (crop == "TabacoA") ans = this.Tabaco_a;
            else if (crop == "TabacoB") ans = this.Tabaco_b;
            else if (crop == "MaizTradicionalA") ans = this.Ma_z_tradicional_a;
            else if (crop == "MaizTradicionalB") ans = this.Ma_z_tradicional_b;
            return ans;

        }
        public string Municipios { get => municipios; set => municipios = value; }
        public int A_o { get => a_o; set => a_o = value; }
        public double Algod_n_a { get => algod_n_a; set => algod_n_a = value; }
        public double Algod_n_b { get => algod_n_b; set => algod_n_b = value; }
        public double Arroz_a { get => arroz_a; set => arroz_a = value; }
        public double Arroz { get => arroz; set => arroz = value; }
        public double Frijol_a { get => frijol_a; set => frijol_a = value; }
        public double Frijol_b { get => frijol_b; set => frijol_b = value; }
        public double Ma_z_tecnificado_a { get => ma_z_tecnificado_a; set => ma_z_tecnificado_a = value; }
        public double Ma_z_tecnificado_b { get => ma_z_tecnificado_b; set => ma_z_tecnificado_b = value; }
        public double Sorgo_a { get => sorgo_a; set => sorgo_a = value; }
        public double Sorgo_b { get => sorgo_b; set => sorgo_b = value; }
        public double Soya_a { get => soya_a; set => soya_a = value; }
        public double Soya_b { get => soya_b; set => soya_b = value; }
        public double Tabaco_a { get => tabaco_a; set => tabaco_a = value; }
        public double Tabaco_b { get => tabaco_b; set => tabaco_b = value; }
        public double Ma_z_tradicional_a { get => ma_z_tradicional_a; set => ma_z_tradicional_a = value; }
        public double Ma_z_tradicional_b { get => ma_z_tradicional_b; set => ma_z_tradicional_b = value; }


    }
}