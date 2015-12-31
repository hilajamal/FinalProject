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
    public partial class F_Patients : Form
    {
        int OriginalID = 0;
        public F_Patients()
        {
            InitializeComponent();
            addCombos();
            loadPatientData();
            OriginalID = (int)CmbPatientID.SelectedValue;
        }

        private void addCombos()
        {

            ClinicTableAdapters.GenderTableAdapter daGender = new ClinicTableAdapters.GenderTableAdapter();
            Clinic.GenderDataTable dtGender = daGender.GetData();
            CmbGender.DataSource = dtGender;
            CmbGender.AutoCompleteMode = AutoCompleteMode.Append;
            CmbGender.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbGender.DisplayMember = "Name";
            CmbGender.ValueMember = "ID";
            CmbGender.SelectedIndex = 0;


            ClinicTableAdapters.RaceTableAdapter daRace = new ClinicTableAdapters.RaceTableAdapter();
            Clinic.RaceDataTable dtRace = daRace.GetData();
            CmbRace.DataSource = dtRace;
            CmbRace.AutoCompleteMode = AutoCompleteMode.Append;
            CmbRace.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbRace.DisplayMember = "Name";
            CmbRace.ValueMember = "ID";
            CmbRace.SelectedIndex = 0;

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

            TxtBirthDate.ValidatingType = typeof(System.DateTime);
            TxtBirthDateUpdate.ValidatingType = typeof(System.DateTime);

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


            Clinic.GenderDataTable dtGenderUpdate = daGender.GetData();
            CmbGenderUpdate.DataSource = dtGenderUpdate;
            CmbGenderUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbGenderUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbGenderUpdate.DisplayMember = "Name";
            CmbGenderUpdate.ValueMember = "ID";
            CmbGenderUpdate.SelectedIndex = 0;


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

            Clinic.RaceDataTable dtRaceUpdate = daRace.GetData();
            CmbRaceUpdate.DataSource = dtRaceUpdate;
            CmbRaceUpdate.AutoCompleteMode = AutoCompleteMode.Append;
            CmbRaceUpdate.AutoCompleteSource = AutoCompleteSource.ListItems;
            CmbRaceUpdate.DisplayMember = "Name";
            CmbRaceUpdate.ValueMember = "ID";
            CmbRaceUpdate.SelectedIndex = 0;

              }

        private void BtnAddNewPatient_Click(object sender, EventArgs e)
        {
            if (validateFieldsAdd())
            {
                DateTime dt = DateTime.ParseExact(TxtBirthDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                int streetNum = 0;
                if(Int32.TryParse(TxtStreetNumber.Text, out streetNum))
                    streetNum = Int32.Parse(TxtStreetNumber.Text);
                else  streetNum = 0;

                int zipCode = 0;
                if(Int32.TryParse(TxtZipCode.Text, out zipCode))
                    zipCode = Int32.Parse(TxtZipCode.Text);
                else  zipCode = 0;

                string fullName = TxtFirstName.Text + " " + TxtLaseName.Text;
                int id = Int32.Parse(TxtID.Text.ToString());
                string father = TxtFather.Text.ToString();
                string mother = TxtMother.Text.ToString();
                string firstname = TxtFirstName.Text.ToString();
                string lastname = TxtLaseName.Text.ToString();
                int country = (int) CmbCountry.SelectedValue;
                int city = (int)CmbCity.SelectedValue;
                int gender = (int)CmbGender.SelectedValue;
                string street = TxtStreet.Text.ToString();
                string email = TxtEmail.Text.ToString();
                string phonehome = TxtPhoneHome.Text.ToString();
                string phonecellular = TxtPhoneCellular.Text.ToString();
                string phonework = TxtPhoneWork.Text.ToString();
                string phoneanother = TxtPhoneAnother.Text.ToString();
                string phonecontact = TxtPhoneContact.Text.ToString();
                int insurence = (int)CmbInsurence.SelectedValue;
                string phonefather = TxtPhoneFather.Text.ToString();
                string phonemother = TxtPhoneMother.Text.ToString();
                string familydoctor = TxtFamilyDoctor.Text.ToString();
                string notes = TxtNotes.Text.ToString();
                int race = (int)CmbRace.SelectedValue;
                string apotropus =TxtApotropus.Text.ToString();




                ClinicTableAdapters.PatientsTableAdapter da = new ClinicTableAdapters.PatientsTableAdapter();
                da.Insert(id, firstname, lastname, fullName, father, mother, country, gender, city, street, streetNum, zipCode, email, phonehome, phonecellular, phonework, phonefather, phonemother, phoneanother, phonecontact, null, null, insurence, familydoctor, notes, race, apotropus, dt);
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
            CmbRaceUpdate.SelectedValue = Int32.Parse(dr["Race"].ToString());
            TxtApotropusUpdate.Text = dr["Apotropus"].ToString();
            TxtFamilyDoctorUpdate.Text = dr["FamilyDoctor"].ToString();
            TxtPhoneHomeUpdate.Text = dr["PhoneHome"].ToString();
            TxtPhoneCellularUpdate.Text = dr["PhoneCellular"].ToString();
            TxtPhoneAnotherUpdate.Text = dr["PhoneAnother"].ToString();
            TxtPhoneFatherUpdate.Text = dr["PhoneFather"].ToString();
            TxtPhoneMotherUpdate.Text = dr["PhoneMother"].ToString();
            TxtPhoneContactUpdate.Text = dr["PhoneContact"].ToString();
            //TxtMainTherapistUpdate.Text = dr["FirstName"].ToString();
            //TxtSecondTherapistUpdate.Text = dr["FirstName"].ToString();
            TxtStreetUpdate.Text = dr["Street"].ToString();
            TxtStreetNumberUpdate.Text = dr["StreetNumber"].ToString();
            TxtZipCodeUpdate.Text = dr["ZipCode"].ToString();
            CmbCountryOfBirthUpdate.SelectedValue = Int32.Parse(dr["BirthCountry"].ToString());
            CmbCityUpdate.SelectedValue = Int32.Parse(dr["City"].ToString());
            CmbGenderUpdate.SelectedValue = Int32.Parse(dr["Gender"].ToString());
            TxtNotesUpdate.Text = dr["Notes"].ToString();
            TxtEmailUpdate.Text = dr["Email"].ToString();

        }

        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            if (validateFieldsUpdate())
            {

                int streetNum = 0;
                if (Int32.TryParse(TxtStreetNumber.Text, out streetNum))
                    streetNum = Int32.Parse(TxtStreetNumber.Text);
                else streetNum = 0;

                int zipCode = 0;
                if (Int32.TryParse(TxtZipCode.Text, out zipCode))
                    zipCode = Int32.Parse(TxtZipCode.Text);
                else zipCode = 0;

                string fullName = TxtFirstNameUpdate.Text + " " + TxtLaseName.Text;
                int id = (int)CmbPatientID.SelectedValue;
                string father = TxtFirstNameUpdate.Text.ToString();
                string mother = TxtMotherNameUpdate.Text.ToString();
                string firstname = TxtFirstNameUpdate.Text.ToString();
                string lastname = TxtFirstNameUpdate.Text.ToString();
                int country = (int)CmbCountryOfBirthUpdate.SelectedValue;
                int city = (int)CmbCityUpdate.SelectedValue;
                int gender = (int)CmbGenderUpdate.SelectedValue;
                string street = TxtStreetUpdate.Text.ToString();
                string email = TxtEmailUpdate.Text.ToString();
                string phonehome = TxtPhoneHomeUpdate.Text.ToString();
                string phonecellular = TxtPhoneCellularUpdate.Text.ToString();
                string phonework = TxtPhoneWotkUpdate.Text.ToString();
                string phoneanother = TxtPhoneAnotherUpdate.Text.ToString();
                string phonecontact = TxtPhoneContactUpdate.Text.ToString();
                int insurence = (int)CmbInsurenceUpdate.SelectedValue;
                string phonefather = TxtPhoneFatherUpdate.Text.ToString();
                string phonemother = TxtPhoneMotherUpdate.Text.ToString();
                string familydoctor = TxtFamilyDoctorUpdate.Text.ToString();
                string notes = TxtNotesUpdate.Text.ToString();
                int race = (int)CmbRaceUpdate.SelectedValue;
                string apotropus = TxtApotropusUpdate.Text.ToString();





                ClinicTableAdapters.PatientsTableAdapter da = new ClinicTableAdapters.PatientsTableAdapter();
                da.UpdateQuery(id, firstname, lastname, fullName, father, mother, country, gender, city, street, streetNum, zipCode, email, phonehome, phonecellular, phonework, phonefather, phonemother, phoneanother, phonecontact, null, null, insurence, familydoctor, notes, race, apotropus, TxtBirthDateUpdate.Text, OriginalID);




            }

        }

        private void CmbPatientID_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPatientData();
            OriginalID = (int)CmbPatientID.SelectedValue;

        }
        }

    }

