package windowManagement;
import windowManagement.WindowManagement.*;

public interface IWindowDimmer extends initialModel.IDevice{
	
	public int getAperture();	
	public void setAperture(int value);	
	public String getWindowId();

}
