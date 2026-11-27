[System.Serializable] public class CommandDto {
 public string kind="command",requestId="",command="",target="";
 public float value;
}
// WPF: JsonSerializer.Serialize(dto,new JsonSerializerOptions{IncludeFields=true})
// Unity: JsonUtility.FromJson<CommandDto>(line)
// Both sides must verify required fields, allowed commands, finite values and ranges.
