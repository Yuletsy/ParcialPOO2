package co.edu.unac;

public class NumberFormatException extends Exception {

	private String message;

	public NumberFormatException(String message) {
		this.message = message;
	}

	@Override
	public String getMessage() {
		return this.message;
	}

}
