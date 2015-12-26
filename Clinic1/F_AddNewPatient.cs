using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Clinic1
{
    public partial class F_AddNewPatient : Form
    {
        public F_AddNewPatient()
        {
            InitializeComponent();
            addCombos();
            loadPatientData();
        }

        private void addCombos()
        {
            List<string> gender = new List<string> { "זכר", "נקבה"};
            CmbGender.DataSource = gender;
            CmbGender.SelectedIndex = 0;
            ClinicTableAdapters.CityTableAdapter cityDa = new ClinicTableAdapters.CityTableAdapter();
            Clinic.CityDataTable cities = cityDa.GetData();
            CmbCity.DataSource = cities;
            CmbCity.AutoCompleteMode = AutoCompleteMode.Append;
            CmbCity.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbCity.DisplayMember = "Name";
            CmbCity.ValueMember = "ID";
            CmbCity.SelectedIndex = 124;

            ClinicTableAdapters.CountryTableAdapter countryDa = new ClinicTableAdapters.CountryTableAdapter();
            Clinic.CountryDataTable countries = countryDa.GetData();
            CmbCountry.DataSource = countries;
            CmbCountry.AutoCompleteMode = AutoCompleteMode.Append;
            CmbCountry.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbCountry.DisplayMember = "Name";
            CmbCountry.ValueMember = "ID";
            CmbCountry.SelectedIndex = 124;

            ClinicTableAdapters.InsurenceAuthorityTableAdapter iaDa = new ClinicTableAdapters.InsurenceAuthorityTableAdapter();
            Clinic.InsurenceAuthorityDataTable isList = iaDa.GetData();
            CmbInsurence.DataSource = isList;
            CmbInsurence.AutoCompleteMode = AutoCompleteMode.Append;
            CmbInsurence.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbInsurence.DisplayMember = "Name";
            CmbInsurence.ValueMember = "ID";
            CmbInsurence.SelectedIndex = 0;

            TxtBirthDate.Mask = "##/##/####";
            TxtBirthDate.ValidatingType = typeof(System.DateTime);



            ClinicTableAdapters.PatientsTableAdapter daPatients = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dtPatients = daPatients.GetData();

            //PatientsID
            CmbPatientID.DataSource = dtPatients;
            CmbPatientID.AutoCompleteMode = AutoCompleteMode.Append;
            CmbPatientID.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbPatientID.DisplayMember = "ID";
            CmbPatientID.ValueMember = "ID";
            CmbPatientID.SelectedIndex = 0;

            Clinic.CountryDataTable countriesUpdate = countryDa.GetData();
            CmbCountryOfBirthUpdate.DataSource = countriesUpdate;
            CmbCountryOfBirthUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbCountryOfBirthUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbCountryOfBirthUpdate.DisplayMember = "Name";
            CmbCountryOfBirthUpdate.ValueMember = "ID";

            CmbGenderUpdate.DataSource = gender;
             Clinic.InsurenceAuthorityDataTable isListUpdate = iaDa.GetData();
             CmbInsurenceUpdate.DataSource = isListUpdate;
             CmbInsurenceUpdate.AutoCompleteMode = AutoCompleteMode.Append;
             CmbInsurenceUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
             CmbInsurenceUpdate.DisplayMember = "Name";
             CmbInsurenceUpdate.ValueMember = "ID";
             CmbInsurenceUpdate.SelectedIndex = 0;


            Clinic.CityDataTable citiesUpdate = cityDa.GetData();
            CmbCityUpdate.DataSource = citiesUpdate;
            CmbCityUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbCityUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbCityUpdate.DisplayMember = "Name";
            CmbCityUpdate.ValueMember = "ID";
              }

        private void BtnAddNewPatient_Click(object sender, EventArgs e)
        {
            if (validateFieldsAdd())
            {
                DateTime bd = DateTime.ParseExact(TxtBirthDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int streetNum = 0;
                if(Int32.TryParse(TxtStreetNumber.Text, out streetNum))
                    streetNum = Int32.Parse(TxtStreetNumber.Text);
                else  streetNum = 0;

                int zipCode = 0;
                if(Int32.TryParse(TxtZipCode.Text, out zipCode))
                    zipCode = Int32.Parse(TxtZipCode.Text);
                else  zipCode = 0;

                string fullName = TxtFirstName.Text + " " + TxtLaseName.Text;

                ClinicTableAdapters.PatientsTableAdapter da = new ClinicTableAdapters.PatientsTableAdapter();
                da.InsertQuery(Int32.Parse(TxtID.Text.ToString()), TxtFirstName.Text.ToString(), TxtLaseName.Text.ToString(), TxtFather.Text.ToString(), TxtMother.Text.ToString(), bd, Int32.Parse(CmbCountry.SelectedValue.ToString()), Int32.Parse(CmbGender.SelectedValue.ToString()), Int32.Parse(CmbCity.SelectedValue.ToString()), TxtStreet.Text, streetNum, zipCode, TxtEmail.Text, TxtPhoneHome.Text, TxtPhoneCellular.Text, TxtPhoneWork.Text, TxtPhoneAnother.Text, TxtPhoneContact.Text, null, null, Int32.Parse(CmbInsurence.SelectedValue.ToString()), fullName, TxtFamilyDoctor.Text, TxtPhoneFather.Text, TxtPhoneMother.Text, TxtNotes.Text);
            }
        }


                private Boolean validateFieldsUpdate()
        {
                          StringBuilder str = new StringBuilder();
            str.Append(" הוסף " );
            Boolean HasErrors = false; //במידה והמשתמש מילא את כל הפרטים לא נדפיס הודעה
            Boolean First_ItemNull = false; //בהוספה ראשונה נשמיט את הפסיק
        

            if (TxtFirstNameUpdate.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם פרטי");
                }
                else
                {
                    str.Append(" שם פרטי");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtFirstNameUpdate.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם משפחה");
                }
                else
                {
                    str.Append(" שם משפחה");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }
            
            if (TxtFirstNameUpdate.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם אב");
                }
                else
                {
                    str.Append(" שם אב");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }
            if (TxtMotherNameUpdate.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם אם");
                }
                else
                {
                    str.Append(" שם אם");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtBirthDateUpdate.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", תאריך לידה");
                }
                else
                {
                    str.Append(" תאריך לידה");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtRaceUpdate.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", לאום");
                }
                else
                {
                    str.Append(" לאום");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtApotropusUpdate.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", אפוטרופוס");
                }
                else
                {
                    str.Append(" אפוטרופוס");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtStreetUpdate.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", רחוב");
                }
                else
                {
                    str.Append(" רחוב");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtZipCodeUpdate.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", מיקוד");
                }
                else
                {
                    str.Append(" מיקוד");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (HasErrors)
            {
                MessageBox.Show(str.ToString());
                return false; //אם חסרים פרטים בשורה יש לבצע את בדיקת התקינות שוב
            }

            return true; //אחרת-אם כל השורה מולאה אל תבצע את בדיקת התקינות שוב

        }



        private Boolean validateFieldsAdd()
        {
                          StringBuilder str = new StringBuilder();
            str.Append(" הוסף " );
            Boolean HasErrors = false; //במידה והמשתמש מילא את כל הפרטים לא נדפיס הודעה
            Boolean First_ItemNull = false; //בהוספה ראשונה נשמיט את הפסיק
            int outVal;
            if (!Int32.TryParse(TxtID.Text, out outVal))
            {
                str.Append(" תעודת זהות");
                HasErrors = true;
                First_ItemNull = true;
            }

            if (TxtFirstName.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם פרטי");
                }
                else
                {
                    str.Append(" שם פרטי");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtLaseName.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם משפחה");
                }
                else
                {
                    str.Append(" שם משפחה");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }
            
            if (TxtFather.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם אב");
                }
                else
                {
                    str.Append(" שם אב");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }
            if (TxtMother.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", שם אם");
                }
                else
                {
                    str.Append(" שם אם");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtBirthDate.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", תאריך לידה");
                }
                else
                {
                    str.Append(" תאריך לידה");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtRace.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", לאום");
                }
                else
                {
                    str.Append(" לאום");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtApotropus.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", אפוטרופוס");
                }
                else
                {
                    str.Append(" אפוטרופוס");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtStreet.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", רחוב");
                }
                else
                {
                    str.Append(" רחוב");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (TxtZipCode.Text == "")
            {
                if (First_ItemNull == true)
                {
                    str.Append(", מיקוד");
                }
                else
                {
                    str.Append(" מיקוד");
                    First_ItemNull = true;
                }
                HasErrors = true;
            }

            if (HasErrors)
            {
                MessageBox.Show(str.ToString());
                return false; //אם חסרים פרטים בשורה יש לבצע את בדיקת התקינות שוב
            }

            return true; //אחרת-אם כל השורה מולאה אל תבצע את בדיקת התקינות שוב

        }

        private void loadPatientData()
        {

            ClinicTableAdapters.PatientsTableAdapter da = new ClinicTableAdapters.PatientsTableAdapter();
            Clinic.PatientsDataTable dt = da.GetDataByID(Int32.Parse(CmbPatientID.SelectedValue.ToString()));
            //Clinic.PatientsRow row = dt.Rows[0];
            DataRow dr = dt.Rows[0];
            TxtFirstNameUpdate.Text = dr["FirstName"].ToString();
            TxtLastNameUpdate.Text = dr["LastName"].ToString();
            TxtFatherNameUpdate.Text = dr["FatherName"].ToString();
            TxtMotherNameUpdate.Text = dr["MotherName"].ToString();
            TxtRaceUpdate.Text = dr["Race"].ToString();
            TxtApotropusUpdate.Text = dr["Apotropus"].ToString();
            TxtFamilyDoctorUpdate.Text = dr["FamilyDoctor"].ToString();
            TxtPhoneHomeUpdate.Text = dr["PhoneHome"].ToString();
            TxtPhoneCellularUpdate.Text = dr["PhoneCellular"].ToString();
            TxtPhoneAnotherUpdate.Text = dr["PhoneAnother"].ToString();
            TxtPhoneFatherUpdate.Text = dr["PhoneFather"].ToString();
            TxtPhoneMotherUpdate.Text = dr["PhoneMother"].ToString();
            TxtContactUpdate.Text = dr["PhoneContact"].ToString();
            //TxtMainTherapistUpdate.Text = dr["FirstName"].ToString();
            //TxtSecondTherapistUpdate.Text = dr["FirstName"].ToString();
            TxtStreetUpdate.Text = dr["Street"].ToString();
            TxtStreetNumberUpdate.Text = dr["StreetNumber"].ToString();
            TxtZipCodeUpdate.Text = dr["ZipCode"].ToString();
            CmbCountryOfBirthUpdate.SelectedIndex = Int32.Parse(dr["BirthCountry"].ToString());
            CmbCityUpdate.SelectedIndex = Int32.Parse(dr["City"].ToString());
            CmbGenderUpdate.SelectedIndex = Int32.Parse(dr["Gender"].ToString());
            TxtNotesUpdate.Text = dr["Notes"].ToString();
            TxtEmailUpdate.Text = dr["Email"].ToString();

        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            if (validateFieldsUpdate())
            {















            }

        }

        private void CmbPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPatientData();
        }
        }

    }

