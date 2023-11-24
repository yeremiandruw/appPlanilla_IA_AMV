package dao;

import bean.Empleado;

public class EmpleadoDao {
	//db.Db db = new db.Db("planillas");
	db.Db db = new db.Db("srv1101.hstgr.io","3306","ua584908256_planillas","Senati2023@","ua584908256_planillas");
	public boolean Login(Empleado empleado) {
		db.Sentencia(String.format("call sp_getEmpleadoLogin('%s','%s')", empleado.getDni(),empleado.getPasswordd()));
		empleado.setEmpleado( db.getRegistro());
		return empleado.getId()>0;
	}

}
