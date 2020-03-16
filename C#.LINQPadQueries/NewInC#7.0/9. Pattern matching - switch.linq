<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Windows.Forms.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Security.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Configuration.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\Accessibility.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Deployment.dll</Reference>
  <Reference>&lt;RuntimeDirectory&gt;\System.Runtime.Serialization.Formatters.Soap.dll</Reference>
  <Namespace>System.Windows.Forms</Namespace>
</Query>

void Main()
{
	Demo (new TextBox());
	Demo (new ComboBox());
	Demo (null);
	Demo (new MonthCalendar());
}

void Demo (Control control)
{
	switch (control)
	{
		case TextBox t:              // We can switch on *type*
			t.Multiline.Dump();
			break;
		
		case ComboBox c when c.DropDownStyle == ComboBoxStyle.DropDown:
			c.Items.Dump();
			break;

		case ComboBox c:             // The ordering of case clauses now matters!
			c.SelectedItem.Dump();
			break;
			
//		case null:
//			"Null".Dump();
//			break;

		default:
			"Unknown".Dump();
			break;

		case null:
			throw new ArgumentNullException(nameof(control));
	}
}

//switch (shape)
//{
//	case Circle c:
//		WriteLine($"circle with radius {c.Radius}");
//		break;
//	case Rectangle s when (s.Length == s.Height):
//		WriteLine($"{s.Length} x {s.Height} square");
//		break;
//	case Rectangle r:
//		WriteLine($"{r.Length} x {r.Height} rectangle");
//		break;
//	default:
//		WriteLine("<unknown shape>");
//		break;
//	case null:
//		throw new ArgumentNullException(nameof(shape));
//}