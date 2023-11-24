package db;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;

public class Db {
	Connection cn= null;
	PreparedStatement ps = null;
	String _IP="localhost", _PORT="3306", _USER="root",  _PASSWORD="", _BD="", _SQL="";
	private String sql;
	
	public Db(String bd) {
		this._BD = bd;
		getConnection();
	}
	public Db(String ip, String port, String user, String password, String bd ) {
	this._IP = ip;
	this._PORT = port;
	this._USER = user;
	this._PASSWORD = password;
	this._BD = bd;
	getConnection();
	}

	private void getConnection() {
		try {
			Class.forName("com.mysql.jdbc.Driver");
			cn = DriverManager.getConnection(String.format("jdbc:mysql://%s:%s/%s",_IP, _PORT, _BD), _USER, _PASSWORD);
		} catch (ClassNotFoundException | SQLException e) {e.printStackTrace();}
	}
	
	
	public void Sentencia(String format) {
		if ( cn == null)return;
		this._SQL = sql;
		try {
			ps = cn.prepareStatement(sql);
		} catch (SQLException e) {e.printStackTrace();}
		
	}

	public String[] getRegistro() {
		if ( cn == null || ps == null) return null;
		try {
		ResultSet rs=ps.executeQuery();
		if (rs.next()){
			String[] aRegistro = new String[rs.getMetaData().getColumnCount()];
			for(int i = 0; i < aRegistro.length; i++)
				aRegistro[i] = rs.getString(i+1).trim();
			return aRegistro;
		}
		}catch (SQLException e) {e.printStackTrace();}
		return null;
	}

}
