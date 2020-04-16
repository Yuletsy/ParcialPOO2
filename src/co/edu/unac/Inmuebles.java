package co.edu.unac;

public abstract class Inmuebles {
	
	protected String id;
	protected String name;
	protected String tipoContrato;
	
	
	public Inmuebles(String id, String name, String tipoContrato) {
		super();
		this.id = id;
		this.name = name;
		this.tipoContrato = tipoContrato; // si es compra o venta
		
	}

}
