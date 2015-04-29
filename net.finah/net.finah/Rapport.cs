﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net.finah
{
  public class Rapport {
	@JsonProperty("Id")
	private int id;
	@JsonProperty("Patient_Id")
	private int patient_Id;
	@JsonProperty("Mantelzorger_Id")
	private int mantelzorger_Id;
	@JsonProperty("Date")
	private Date date;
	@JsonProperty("Vragenlijst_Id")
	private int vragenlijst_Id;
	@JsonProperty("Dokter_Id")
	private int dokter_id;

	public void setId(int id) {
		this.id = id;
	}
	public void setDate(Date date) {
		this.date = date;
	}
	public void setVragenlijst_Id(int vragenlijst_Id) {
		this.vragenlijst_Id = vragenlijst_Id;
	}

	public String toString(){
		return id + ":" + patient_Id + "," + mantelzorger_Id + "-" + date + "(" + vragenlijst_Id + ")";
	}

}
}