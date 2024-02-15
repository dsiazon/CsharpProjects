public static T GetValue<T>(this XElement e, string name, T def_value = ) {
    if (e != null) {
        XElement x = e.Elements(XName.Get(name)).FirstOrDefault();
        if (x != null && !string.IsNullOrWhiteSpace(x.Value.Trim())) {
			return ______________________________________________;
		}
	}
	return def_value;




