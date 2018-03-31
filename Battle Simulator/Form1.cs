// Yikwun Zhang
// March 5, 2013
// This program is used to simulate battle between two characters

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {        
        // To store the current hit points of user
        int currentHPUser = 100;

        // To store the current hit points of enemy
        int currentHPEnemy = 100;

        // To store the current MP of user
        int currentMPUser = 20;

        // To store the current MP of enemy
        int currentMPEnemy = 20;

        // To count the number of heals left
        int userHealCounter = 3;

        // To count the number of heals left for enemy
        int enemyHealCounter = 3;

        //To make a random number generator
        Random numberGenerator = new Random();

        public Form1()
        {
            InitializeComponent();             
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            // Enemy HP minus 15
            currentHPEnemy -= 15;
            lblHPEnemy.Text = currentHPEnemy.ToString();

            lblUserActions1.Text = "Agumon attacked.";
            lblUserActions2.Text = "Blissey HP - 15";

            // If enemy HP less than one, message box pops up
            if (currentHPEnemy < 1)
            {
                currentHPEnemy = 0;
                lblHPEnemy.Text = currentHPEnemy.ToString();
                MessageBox.Show("You win!");
                this.Close();
                Application.Exit();
            }

            enemyAI();
            updateStats();
        }

        private void btnSpecialAttack_Click(object sender, EventArgs e)
        {
            // If user MP greater than 1, user will special attack
            if (currentMPUser >= 1)
            {
                // Enemy HP minus 25
                currentHPEnemy -= 25;
                lblHPEnemy.Text = currentHPEnemy.ToString();

                // User MP minus 5
                currentMPUser -= 5;
                lblMPUser.Text = currentMPUser.ToString();

                lblUserActions1.Text = "Agumon used Special Attack.";
                lblUserActions2.Text = "Blissey HP - 25, Agumon MP -5";

                enemyAI();
                {
                    // If enemy HP less than one, message box pops up
                    if (currentHPEnemy <= 0)
                    {
                        currentHPEnemy = 0;
                        lblHPEnemy.Text = currentHPEnemy.ToString();
                        MessageBox.Show("You win!");
                        this.Close();
                        Application.Exit();
                    }

                    // If enemy HP and user MP less than one, message box pops up
                    else if (currentHPEnemy <= 0 && currentMPUser <= 0)
                    {
                        currentHPEnemy = 0;
                        lblHPEnemy.Text = currentHPEnemy.ToString();
                        MessageBox.Show("You win!");
                        this.Close();
                        Application.Exit();
                    }
                }
            }

            // If user mp less than 0, negates effect of button
            else if (currentMPUser <= 0)
            {
                currentMPUser = 0;
                lblMPUser.Text = currentMPUser.ToString();

                MessageBox.Show("No MP");
            }

            updateStats();

        }

        private void btnHeal_Click(object sender, EventArgs e)
        {
            userHealCounter = userHealCounter - 1;
            lblHealUser.Text = userHealCounter.ToString();

            lblUserActions1.Text = "Agumon healed.";
            lblUserActions2.Text = "Agumon HP + 20, Heals left - 1";

            // If heal counter greater than zero, user will heal
            if (userHealCounter >= 0)
            {
                // User HP plus 20
                currentHPUser += 20;
                lblHPUser.Text = currentHPUser.ToString();

                enemyAI();
            }

            // If heal counter is less than zero, message box pops up
            else if (userHealCounter < 0)
            {
                userHealCounter = 0;
                lblHealUser.Text = userHealCounter.ToString();
                MessageBox.Show("No heals left!");
            }

            updateStats();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            // Change to heal counter to 0 if less than 0
            if (userHealCounter < 0)
            {
                userHealCounter = 0;
            }

            // Else, user will run away
            else
            {
                // User HP plus 10
                currentHPUser += 10;
                lblHPUser.Text = currentHPUser.ToString();

                // User MP plus 5
                currentMPUser += 5;
                lblMPUser.Text = currentMPUser.ToString();

                // User heals plus 1
                userHealCounter += 1;
                lblHealUser.Text = userHealCounter.ToString();

                // Enemy HP plus 10
                currentHPEnemy += 10;
                lblHPEnemy.Text = currentHPEnemy.ToString();

                lblUserActions1.Text = "Agumon ran away.";
                lblUserActions2.Text = ("Agumon HP + 10, MP + 5, Heals left + 1, Blissey HP + 10");
            }

            enemyAI();
            updateStats();            
        }

        public void enemyAI()
        {
            // To save the random integer
            numberGenerator.Next();

            // Make a random number between 0 and 3 
            int randomInt = numberGenerator.Next(0, 4);

            {
                // If enemy HP between 10 and 25, enemy will heal
                if (currentHPEnemy > 10 && currentHPEnemy <= 25)
                {
                    randomInt = 2;
                }

                // If enemy HP less than 10, enemy will run
                else if (currentHPEnemy <= 10)
                {
                    randomInt = 3;
                }
            }

            // If random number is zero, user will get attacked
            if (randomInt == 0)
            {
                // User HP minus 5
                currentHPUser -= 15;
                lblHPUser.Text = currentHPUser.ToString();

                lblEnemyActions1.Text = "Blissey attacked.";
                lblEnemyActions2.Text = "Agumon HP - 15";

                // If user HP less than zero, message box says you lose
                if (currentHPUser <= 0)
                {
                    currentHPUser = 0;
                    lblHPUser.Text = currentHPUser.ToString();

                    MessageBox.Show("You lose!");
                    this.Close();
                    Application.Exit(); 
                }               
            }

            // Else if random number is one, user will get special attacked
            else if (randomInt == 1)
            {
                // If enemy MP greater than one, enemy will special attack
                if (currentMPEnemy >= 1)
                {
                    // User HP minus 25
                    currentHPUser -= 25;
                    lblHPUser.Text = currentHPUser.ToString();

                    // Enemy MP minus 5
                    currentMPEnemy -= 5;
                    lblMPEnemy.Text = currentMPEnemy.ToString();

                    lblEnemyActions1.Text = "Blissey used Special Attack.";
                    lblEnemyActions2.Text = "Agumon HP - 25, Blissey MP - 5";
                    {
                        // If user HP less than zero, message box says you lose
                        if (currentHPUser <= 0)
                        {
                            currentHPUser = 0;
                            lblHPUser.Text = currentHPUser.ToString();

                            MessageBox.Show("You lose!");
                            this.Close();
                            Application.Exit();
                        }

                        // If enemy HP and user MP less than one, message box pops up
                        else if (currentHPUser < 1 && currentMPEnemy < 1)
                        {
                            currentHPUser = 0;
                            lblHPUser.Text = currentHPUser.ToString();

                            MessageBox.Show("You lose!");
                            this.Close();
                            Application.Exit();
                        }
                    }
                }

                // If user MP less than zero, negates effect of button
                else if (currentMPEnemy <= 0)
                {
                    currentMPEnemy = 0;
                    lblMPUser.Text = currentMPUser.ToString();
                    randomInt = numberGenerator.Next(0, 4);
                }                
            }

            // Else if random number is two, enemy will heal
            else if (randomInt == 2)
            {              
                // If heal counter greater than zero, enemy will heal
                if (enemyHealCounter > 0)
                {
                    // Enemy HP plus 20
                    currentHPEnemy += 20;
                    lblHPEnemy.Text = currentHPEnemy.ToString();

                    // Enemy heals minus 1
                    enemyHealCounter = enemyHealCounter - 1;
                    lblHealEnemy.Text = enemyHealCounter.ToString();                    

                    lblEnemyActions1.Text = "Blissey healed.";
                    lblEnemyActions2.Text = "Blissey HP + 20, Heals left - 1";
                }

                // Change heal counter to zero if less than zero, enemy will also run instead
                else if (enemyHealCounter <= 0)
                {                    
                    enemyHealCounter = 0;
                    lblHealEnemy.Text = enemyHealCounter.ToString();
                    randomInt = 3;                  
                }
            }

            // Else, enemy will run
            else
            {
                lblEnemyActions1.Text = "Blissey ran away.";
                lblEnemyActions2.Text = "Blissey HP + 10, MP + 10, Heals left + 1, Agumon HP + 10";

                // If enemy HP less than 0, message box pops up
                if (currentHPEnemy <= 0)
                {
                    currentHPEnemy = 0;
                    lblHPEnemy.Text = currentHPEnemy.ToString();

                    MessageBox.Show("You win!");
                    this.Close();
                    Application.Exit();
                }

                // Enemy HP plus 10
                currentHPEnemy += 10;
                lblHPEnemy.Text = currentHPEnemy.ToString();

                // Enemy MP plus 5
                currentMPEnemy += 5;
                lblMPEnemy.Text = currentMPEnemy.ToString();

                // Enemy heals plus 1
                enemyHealCounter += 1;
                lblHealEnemy.Text = enemyHealCounter.ToString();

                // User HP plus 10
                currentHPUser += 10;
                lblHPUser.Text = currentHPUser.ToString();
            }
        }

        public void updateStats()
        {
            picHPUser.Width = currentHPUser;
            picHPEnemy.Width = currentHPEnemy;
            picMPUser.Width = currentMPUser;
            picMPEnemy.Width = currentMPEnemy;

            {
                // Change color if HP is less than 30
                if (currentHPUser <= 30)
                {
                    picHPUser.BackColor = Color.Red;
                }

                // Change color if HP is less than 60
                else if (currentHPUser <= 60)
                {
                    picHPUser.BackColor = Color.Orange;
                }

                // Change color if HP is higher than 60
                else
                {
                    picHPUser.BackColor = Color.Lime;
                }
            }

            {
                // Change color if enemy HP is less than 30
                if (currentHPEnemy <= 30)
                {
                    picHPEnemy.BackColor = Color.Red;
                }

                // Change color if enemy HP is less than 60
                else if (currentHPEnemy <= 60)
                {
                    picHPEnemy.BackColor = Color.Orange;
                }

                // Change color if enemy HP is higher than 60
                else
                {
                    picHPEnemy.BackColor = Color.Lime;
                }
            }
        }
    }
}
