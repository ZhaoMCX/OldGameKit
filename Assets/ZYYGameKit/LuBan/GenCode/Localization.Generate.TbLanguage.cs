
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace ZYYGameKit.Localization.Generate
{
public partial class TbLanguage
{
    private readonly System.Collections.Generic.Dictionary<string, Localization.Generate.Language> _dataMap;
    private readonly System.Collections.Generic.List<Localization.Generate.Language> _dataList;
    
    public TbLanguage(JSONNode _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<string, Localization.Generate.Language>();
        _dataList = new System.Collections.Generic.List<Localization.Generate.Language>();
        
        foreach(JSONNode _ele in _buf.Children)
        {
            Localization.Generate.Language _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = Localization.Generate.Language.DeserializeLanguage(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Key, _v);
        }
    }

    public System.Collections.Generic.Dictionary<string, Localization.Generate.Language> DataMap => _dataMap;
    public System.Collections.Generic.List<Localization.Generate.Language> DataList => _dataList;

    public Localization.Generate.Language GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Localization.Generate.Language Get(string key) => _dataMap[key];
    public Localization.Generate.Language this[string key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}
