using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static THA_4.Form1;

namespace THA_4
{
    public partial class Form1 : Form
    {
        List<Team> teams = new List<Team>();

        public class Team
        {
            public string country;
            public string teamname;
            public string city;
            public List<Player> players = new List<Player>();
        }
        public class Player
        {
            public string playername;
            public string playernum;
            public string playerpos;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void update()
        {
            comboboxteam.Items.Clear();
            for (int i = 0; i < teams.Count; i++)
            {
                if(comboboxcountry.Text == teams[i].country)
                {
                    comboboxteam.Items.Add(teams[i].teamname);
                }
            }
            listboxresult.Items.Clear();
            for (int i = 0; i < teams.Count; i++)
            {
                if (comboboxteam.Text == teams[i].teamname)
                {
                    for (int j = 0; j < teams[i].players.Count; j++)
                    {
                        listboxresult.Items.Add("(" + teams[i].players[j].playernum + ") " + teams[i].players[j].playername + ", " + teams[i].players[j].playerpos);
                    }
                }
            }
            comboboxcountry.Items.Clear();
            for (int i = 0; i < teams.Count; i++)
            {
                int tess = 0;
                foreach (string s in comboboxcountry.Items) // COUNTRY LIST
                {
                    if (s == teams[i].country)
                    {
                        tess++;
                    }
                }
                if (tess == 0)
                {
                    comboboxcountry.Items.Add(teams[i].country);
                }
            }
        }

        private void comboboxcountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboboxteam.Items.Clear();
            for (int i = 0; i < teams.Count; i++)
            {
                if (comboboxcountry.Text == teams[i].country)
                {
                    comboboxteam.Items.Add(teams[i].teamname);
                }
            }
        }

        private void addteam_Click(object sender, EventArgs e)
        {
            if (textboxcountry.Text == "" || textboxteamname.Text == "" || textboxcity.Text == "")
            {
                MessageBox.Show("ALL ITEMS TIDAK BOLEH EMPTY");
            }
            else
            {
                int a = 0;
                for (int i = 0; i < teams.Count; i++)
                {
                    if (textboxteamname.Text == teams[i].teamname)
                    {
                        a++;
                    }
                }
                if (a > 0)
                {
                    MessageBox.Show("ERORR, SUDAH ADA NAMA TEAM YANG SAMA");
                }
                else
                {
                    Team baru = new Team();
                    baru.country = textboxcountry.Text;
                    baru.teamname = textboxteamname.Text;
                    baru.city = textboxcity.Text;
                    teams.Add(baru);
                }
                textboxcountry.Text = "";
                textboxteamname.Text = "";
                textboxcity.Text = "";
            }
            update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Team satu = new Team(); // class team
            satu.country = "Indonesia";
            satu.teamname = "Arema";
            satu.city = "Malang";
            List<string> playernamearema = new List<string>() {"Joko Susilo", "Bayu Aji", "Sérgio Silva" , "Bagas Adi", " Evan Dimas",
                "Iman Budi Hernandi", "Renshi Yamaguchi" ,"Muhammad Rafli", "Gian Zola","Hamzah Titofani","Jayus Hariono" };
            List<string> posarema = new List<string>() { "DF", "DF", "DF", "DF", "MF", "MF", "MF", "FW", "MF" ,"MF","GK"};
            List<string> numberarema = new List<string>() { "1", "3", "5", "6", "99", "76", "48", "11", "78", "55", "24" };
            for(int i=0; i<playernamearema.Count; i++)
            {
                Player satuu = new Player();
                satuu.playername = playernamearema[i];
                satuu.playerpos = posarema[i];
                satuu.playernum = numberarema[i];
                satu.players.Add(satuu);
            }
            teams.Add(satu);
            List<string> PSIS = new List<string>() { };
            //////////////////////////////////////////////////////
            Team dua = new Team();
            dua.country = "Indonesia";
            dua.teamname = "PSIS";
            dua.city = "Solo";
            List<string> playernamepsis= new List<string>() {"Muhammad Riyandi", "Arif Budiyono", "Jaimerson" , "Ferdinand Sinaga", "Irfan Jauhari",
                "Iman Budi Hernandi", "Taufiq Febriyanto" ,"Samsul Arif", "Alexis Messidoro","Gavin Kwan Adsit","Chrystna Bhagascara" };
            List<string> pospsis = new List<string>() { "MF", "MF", "MF", "DF", "DF", "DF", "MF", "FW", "DF", "MF", "GK" };
            List<string> numberpsis = new List<string>() { "7", "43", "5", "65", "19", "76", "14", "21", "78", "65", "24" };
            for (int i = 0; i < playernamepsis.Count; i++)
            {
                Player duaa = new Player();
                duaa.playername = playernamepsis[i];
                duaa.playerpos = pospsis[i];
                duaa.playernum = numberpsis[i];
                dua.players.Add(duaa);
            }
            teams.Add(dua);
            /////////////////////////////////////////////////////
            Team tiga = new Team();
            tiga.country = "Spanyol";
            tiga.teamname = "Barcelona FC";
            tiga.city = "Barcelona";
            List<string> playernamebarcelona = new List<string>() {"Marc-Andre ter Stegen", "Bayu Aji", "Sérgio Silva" , "Bagas Adi", " Evan Dimas",
                "Iman Budi Hernandi", "Renshi Yamaguchi" ,"Muhammad Rafli", "Gian Zola","Hamzah Titofani","Jayus Hariono" };
            List<string> posbarcelona = new List<string>() { "DF", "DF", "DF", "DF", "MF", "MF", "MF", "FW", "MF", "MF", "GK" };
            List<string> numberbarcelona = new List<string>() { "77", "44", "15", "95", "11", "72", "12", "31", "88", "54", "22" };
            for (int i = 0; i < playernamepsis.Count; i++)
            {
                Player tigaa = new Player();
                tigaa.playername = playernamebarcelona[i];
                tigaa.playerpos = posbarcelona[i];
                tigaa.playernum = numberbarcelona[i];
                tiga.players.Add(tigaa);
            }
            teams.Add(tiga);
            update();
        }

        private void comboboxteam_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxresult.Items.Clear();
            for(int i = 0; i < teams.Count; i++)
            {
                if(comboboxteam.Text == teams[i].teamname)
                {
                    for(int j = 0; j < teams[i].players.Count; j++)
                    {
                        listboxresult.Items.Add("(" + teams[i].players[j].playernum + ") " + teams[i].players[j].playername + ", " + teams[i].players[j].playerpos);
                    }
                }
            }
        }

        private void textboxteamname_TextChanged(object sender, EventArgs e)
        {

        }

        private void addplayer_Click(object sender, EventArgs e)
        {
            if(textboxplayername.Text == "" || textboxnumber.Text =="" || position.Text == "")
            {
                MessageBox.Show("ALL ITEMS TIDAK BOLEH EMPTY");
            }
            else
            {
                int a = 0;
                for(int i = 0; i < teams.Count; i++)
                {
                    if (comboboxcountry.Text == teams[i].country && comboboxteam.Text == teams[i].teamname)
                    {
                        Player satuu = new Player();
                        for(int j = 0;j< teams[i].players.Count; j++)
                        {
                            if (textboxplayername.Text == teams[i].players[j].playername)
                            {
                                a++;
                            }
                        }
                        if(a > 0)
                        {
                            MessageBox.Show("ERORR, SUDAH ADA NAMA PLAYER YANG SAMA");
                        }
                        else
                        {
                            satuu.playername = textboxplayername.Text;
                            satuu.playerpos = position.Text;
                            satuu.playernum = textboxnumber.Text;
                            teams[i].players.Add(satuu);
                        }
                    }
                }

            }
            update();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < teams.Count; i++)
            {
                if (teams[i].teamname == comboboxteam.Text)
                {
                    if (teams[i].players.Count <= 11)
                    {
                        MessageBox.Show("Eror, jumlah gada 11 mau di remove");
                    }
                    else
                    {
                        for (int j = 0; j < teams[i].players.Count; j++)
                        {
                            if(listboxresult.Text == "(" + teams[i].players[j].playernum + ") " + teams[i].players[j].playername + ", " + teams[i].players[j].playerpos)
                            {
                                teams[i].players.Remove(teams[i].players[j]);
                            }
                        }
                    }
                }
            }
            update();
        }
    }
}
