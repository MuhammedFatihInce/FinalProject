﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
	public class Order:IEntity
	{
		public int OrderId { get; set; }
		public int Customer { get; set; }
		public int EmployeeId { get; set; }
		public DateTime OrderDate { get; set; }
		public string ShippCity { get; set; }
	}
}
