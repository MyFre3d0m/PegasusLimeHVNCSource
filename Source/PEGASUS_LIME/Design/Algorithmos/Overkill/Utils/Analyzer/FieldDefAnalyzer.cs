using dnlib.DotNet;

namespace PEGASUS_LIME.Design.Algorithmos.Overkill.Utils.Analyzer
{
	public class FieldDefAnalyzer : DefAnalyzer
	{
		public override bool Execute(object context)
		{
			FieldDef fieldDef = (FieldDef)context;
			if (fieldDef.IsRuntimeSpecialName)
			{
				return false;
			}
			if (fieldDef.IsLiteral && fieldDef.DeclaringType.IsEnum)
			{
				return false;
			}
			return true;
		}
	}
}
