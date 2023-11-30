import java.util.ArrayList;
import java.util.List;

public class Basin {
    public int size;
    static List<Integer> itemsInBasin = new ArrayList<Integer>();
    public Basin(int size,  List<Integer> numInBasin){
        this.size = size;
        this.itemsInBasin = numInBasin;
    }

    public Basin(){

    }

    public void addItemstoBasin(int newItem){
        this.itemsInBasin.add(newItem);

    }
}
