using System.Collections.ObjectModel;
public class EquipmentNode {
 public string Id {get;set;}=""; public string Name {get;set;}="";
 public ObservableCollection<EquipmentNode> Children {get;}=new();
}
