package co.edu.unac;
import java.util.*;

public class Main {

	public static void main(String[] args) {
		
		
		
		Scanner sc = new Scanner(System.in);
		System.out.println("-------------------------------");
		System.out.println("Ingrese id, nombre y el tipo de contrato");
		Inquilinos i1 = new Inquilinos(sc.nextLine(), sc.nextLine(), sc.nextLine());
	
		System.out.println("-------------------------------");
		Propietarios p1 = new Propietarios(sc.nextLine(), sc.nextLine(),sc.nextLine());
		System.out.println("Ingrese el numero de contrato");
		
		try {
			Contrato c1 = new Contrato(p1, i1, sc.nextInt());
		}
		catch (NumberFormatException ex) {
            System.out.println(ex.getMessage());
            System.out.println("no es valido");
		}
	
	}

}

