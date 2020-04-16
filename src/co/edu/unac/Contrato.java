package co.edu.unac;

public class Contrato {
	private Propietarios prop;
	private Inquilinos inq;
	private int numContra;

	public Contrato() {
	}

	public Contrato(Propietarios prop, Inquilinos inq, int numContra) throws NumberFormatException {
		String cadena1 = "123123457";
		        
		if ((numContra != Integer.parseInt(cadena1))){//&& (Integer.parseInt(cadena2) != numContra  )) {
			System.out.println(numContra + " es valido este contrato ");
			System.out.println(cadena1 +  " es valido este contrato ");
			this.prop = prop;
			this.inq = inq;
			this.numContra = numContra;
		}
		else {
			throw new NumberFormatException("Este contrato no funciona");

		}
	}

	public Contrato(Inquilinos i1, Propietarios p1, int nextInt) {
		// TODO Auto-generated constructor stub
	}

	public Propietarios getProp() {
		return prop;
	}

	public void setProp(Propietarios prop) {
		this.prop = prop;
	}

	public Inquilinos getInq() {
		return inq;
	}

	public void setInq(Inquilinos inq) {
		this.inq = inq;
	}

	public int getNumContra() {
		return numContra;
	}

	public void setNumContra(int numContra) {
		this.numContra = numContra;
	}

}
