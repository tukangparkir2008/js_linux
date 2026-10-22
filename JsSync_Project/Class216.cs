using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

internal sealed class Class216
{
	private readonly DataGridView dataGridView_0;

	private readonly Hashtable hashtable_0 = new Hashtable();

	private readonly Hashtable hashtable_1 = new Hashtable();

	public Class216(DataGridView dataGridView_1, bool bool_0, bool bool_1)
	{
		dataGridView_0 = dataGridView_1;
		dataGridView_0.Columns.Clear();
		dataGridView_0.Rows.Clear();
		dataGridView_0.AllowUserToAddRows = bool_0;
		dataGridView_0.AllowUserToDeleteRows = bool_1;
		dataGridView_0.CellClick += dataGridView_0_CellClick;
	}

	private void dataGridView_0_CellClick(object sender, DataGridViewCellEventArgs e)
	{
		if (hashtable_1.ContainsKey(e.ColumnIndex) && e.RowIndex >= 0 && dataGridView_0.Rows.Count > 0)
		{
			((Delegate22)hashtable_1[e.ColumnIndex])(dataGridViewRow_0: dataGridView_0.Rows[e.RowIndex], int_0: e.RowIndex);
		}
	}

	public void method_0(int int_0, Delegate24 delegate24_0)
	{
		hashtable_0.Add(int_0, delegate24_0);
	}

	public void method_1(int int_0, Delegate22 delegate22_0)
	{
		hashtable_1.Add(int_0, delegate22_0);
	}

	public void method_2(string string_0, int int_0, bool bool_0)
	{
		Color backColor = (bool_0 ? Color.AliceBlue : Color.White);
		DataGridViewTextBoxColumn dataGridViewColumn = new DataGridViewTextBoxColumn
		{
			Name = string_0,
			Width = int_0,
			ReadOnly = bool_0,
			DefaultCellStyle = 
			{
				BackColor = backColor
			}
		};
		dataGridView_0.Columns.Add(dataGridViewColumn);
	}

	public void method_3(string string_0, int int_0, bool bool_0)
	{
		Color backColor = (bool_0 ? Color.AliceBlue : Color.White);
		DataGridViewTextBoxColumn dataGridViewColumn = new DataGridViewTextBoxColumn
		{
			Name = string_0,
			Width = int_0,
			ReadOnly = bool_0,
			DefaultCellStyle = 
			{
				BackColor = backColor,
				WrapMode = DataGridViewTriState.True
			}
		};
		dataGridView_0.Columns.Add(dataGridViewColumn);
	}

	public void method_4()
	{
		DataGridViewTextBoxColumn dataGridViewColumn = new DataGridViewTextBoxColumn
		{
			Visible = false,
			ReadOnly = true
		};
		dataGridView_0.Columns.Add(dataGridViewColumn);
	}

	public void method_5(string string_0, int int_0, bool bool_0)
	{
		Color backColor = (bool_0 ? Color.AliceBlue : Color.White);
		DataGridViewCheckBoxColumn dataGridViewColumn = new DataGridViewCheckBoxColumn
		{
			Name = string_0,
			Width = int_0,
			ReadOnly = bool_0,
			DefaultCellStyle = 
			{
				BackColor = backColor
			}
		};
		dataGridView_0.Columns.Add(dataGridViewColumn);
	}

	public void method_6(string string_0, int int_0)
	{
		DataGridViewImageColumn dataGridViewColumn = new DataGridViewImageColumn
		{
			Name = string_0,
			Width = int_0,
			ReadOnly = true
		};
		dataGridView_0.Columns.Add(dataGridViewColumn);
	}

	public void method_7(string string_0, int int_0)
	{
		DataGridViewButtonColumn dataGridViewColumn = new DataGridViewButtonColumn
		{
			Name = string_0,
			Width = int_0,
			ReadOnly = false
		};
		dataGridView_0.Columns.Add(dataGridViewColumn);
	}

	public void method_8(string string_0, int int_0, List<string> list_0)
	{
		DataGridViewComboBoxColumn dataGridViewComboBoxColumn = new DataGridViewComboBoxColumn
		{
			Name = string_0,
			Width = int_0
		};
		foreach (string item in list_0)
		{
			dataGridViewComboBoxColumn.Items.Add(item);
		}
		dataGridView_0.Columns.Add(dataGridViewComboBoxColumn);
	}

	public void method_9(DataTable dataTable_0)
	{
		dataGridView_0.Rows.Clear();
		foreach (DataRow row in dataTable_0.Rows)
		{
			object[] array = new object[dataGridView_0.Columns.Count];
			for (int i = 0; i < dataGridView_0.Columns.Count; i++)
			{
				if (hashtable_0.ContainsKey(i))
				{
					Delegate24 @delegate = (Delegate24)hashtable_0[i];
					array[i] = @delegate(row[i]);
				}
				else
				{
					array[i] = row[i];
				}
			}
			dataGridView_0.Rows.Add(array);
		}
	}

	public bool method_10(string string_0, int int_0)
	{
		bool flag = false;
		int num = 0;
		while (!flag && num < dataGridView_0.Rows.Count)
		{
			flag = dataGridView_0.Rows[num].Cells[int_0].Value.ToString().Trim().ToLower()
				.Equals(string_0.Trim().ToLower());
			num++;
		}
		return flag;
	}

	public void method_11(object[] object_0)
	{
		dataGridView_0.Rows.Add(object_0);
	}

	public void method_12()
	{
		dataGridView_0.Rows.Clear();
	}

	public DataTable method_13(DataTable dataTable_0)
	{
		DataTable dataTable = new DataTable();
		foreach (DataColumn column in dataTable_0.Columns)
		{
			dataTable.Columns.Add(column.ColumnName, column.DataType);
		}
		for (int i = 0; i < dataGridView_0.Rows.Count; i++)
		{
			int num = 0;
			DataRow dataRow = dataTable.NewRow();
			foreach (DataColumn column2 in dataTable.Columns)
			{
				dataRow[column2.ColumnName] = dataGridView_0.Rows[i].Cells[num].Value;
				num++;
			}
			dataTable.Rows.Add(dataRow);
		}
		return dataTable;
	}

	public DataTable method_14(int[] int_0)
	{
		DataTable dataTable = new DataTable();
		for (int i = 0; i < int_0.Length; i++)
		{
			dataTable.Columns.Add(i.ToString(), Type.GetType(Class84.smethod_0(-994542528)));
		}
		for (int j = 0; j < dataGridView_0.Rows.Count; j++)
		{
			DataRow dataRow = dataTable.NewRow();
			for (int k = 0; k < int_0.Length; k++)
			{
				int index = int_0[k];
				dataRow[k] = dataGridView_0.Rows[j].Cells[index].Value;
			}
			dataTable.Rows.Add(dataRow);
		}
		return dataTable;
	}

	public void method_15(ref DataTable dataTable_0)
	{
		for (int i = 0; i < dataGridView_0.Rows.Count; i++)
		{
			DataRow dataRow = dataTable_0.NewRow();
			for (int j = 0; j < dataTable_0.Columns.Count; j++)
			{
				dataRow[j] = dataGridView_0.Rows[i].Cells[j].Value;
			}
			dataTable_0.Rows.Add(dataRow);
		}
	}

	public DataTable method_16()
	{
		DataTable dataTable = new DataTable();
		for (int i = 0; i < dataGridView_0.Columns.Count; i++)
		{
			dataTable.Columns.Add(i.ToString(), Type.GetType(Class84.smethod_0(-994542528)));
		}
		for (int j = 0; j < dataGridView_0.Rows.Count; j++)
		{
			DataRow dataRow = dataTable.NewRow();
			for (int k = 0; k < dataGridView_0.Columns.Count; k++)
			{
				dataRow[k] = dataGridView_0.Rows[j].Cells[k].Value;
			}
			dataTable.Rows.Add(dataRow);
		}
		return dataTable;
	}

	public int method_17()
	{
		return dataGridView_0.Rows.Count;
	}

	public void method_18(int int_0)
	{
		for (int i = 0; i < dataGridView_0.Rows.Count; i++)
		{
			dataGridView_0.Rows[i].Height = int_0;
		}
	}
}
