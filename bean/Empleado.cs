using System.Data;

namespace appPlanilla_IA_AMV.bean
{
    internal class Empleado
    {
        #region Propiedades
        public int id { get; set; }
        public string Dni { get; set; }
        public string Ruc { get; set; }
        public string Nombres { get; set; }
        public string ApeliidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public string Passwordd { get; set; }
        public int idDomicilio { get; set; }
        public int idEstadoCivil { get; set; }
        public int idNivelEducativo { get; set; }
        public int idDepartamento { get; set; }
        public int idProvincia { get; set; }
        public int idDistrito { get; set; }
        #endregion

        #region Mètodos

        public void setRegistro(DataRow dr)
        {
            if (dr == null) return;

            id = int.Parse(dr["id"].ToString());
            Dni = dr["Dni"].ToString();
            Ruc = dr["Ruc"].ToString();
            Nombres = dr["Nombres"].ToString();
            ApeliidoPaterno = dr["ApellidoPaterno"].ToString();
            ApellidoMaterno = dr["ApellidoMaterno"].ToString();
            FechaNacimiento = dr["FechaNacimiento"].ToString();
            Direccion = dr["FechaNacimiento"].ToString();
            Correo = dr["Correo"].ToString();
            Celular = dr["Celular"].ToString();
            Passwordd = dr["Passwordd"].ToString();
            idDomicilio = int.Parse(dr["idDomicilio"].ToString());
            idEstadoCivil = int.Parse(dr["idEstadoCivil"].ToString());
            idNivelEducativo = int.Parse(dr["idNivelEducativo"].ToString());
            idDepartamento = int.Parse(dr["idDepartamento"].ToString());
            idProvincia = int.Parse(dr["idProvincia"].ToString());
            idDistrito = int.Parse(dr["idDistrito"].ToString());
        }
            #endregion      

        // cambios a subir
    }
}
