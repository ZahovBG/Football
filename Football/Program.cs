using System;
using System.Collections.Generic;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach t1Coach = new Coach("Steve", 45);
            Goalkeeper t1Goalkeeper = new Goalkeeper("Ivan", 35, 1, 184);
            Defender t1Defender1 = new Defender("Dragan", 30, 5, 180);
            Defender t1Defender2 = new Defender("Stefan", 25, 6, 182);
            Defender t1Defender3 = new Defender("Petko", 28, 7, 185);
            Defender t1Defender4 = new Defender("Ismail", 30, 8, 178);
            Midfield t1Midfield1 = new Midfield("Strahil", 24, 9, 184);
            Midfield t1Midfield2 = new Midfield("Stoqn", 26, 10, 180);
            Midfield t1Midfield3 = new Midfield("Atanas", 27,12, 184);
            Striker t1Striker1 = new Striker("Yoan", 38, 11, 185);
            Striker t1Striker2 = new Striker("Rumqn", 34, 13, 183);
            Striker t1Striker3 = new Striker("Jonatn", 41, 14, 181);
            List<FootbalPlayer> team1Players = new List<FootbalPlayer>
            {
                t1Goalkeeper,
                t1Defender1,
                t1Defender2,
                t1Defender3,
                t1Defender4,
                t1Midfield1,
                t1Midfield2,
                t1Midfield3,
                t1Striker1,
                t1Striker2,
                t1Striker3,
            };
            Team team1 = new Team(t1Coach, team1Players);

            Coach t2Coach = new Coach("Matt", 40);
            Goalkeeper t2Goalkeeper = new Goalkeeper("John", 38, 4, 190);
            Defender t2Defender1 = new Defender("Steve", 30, 5, 180);
            Defender t2Defender2 = new Defender("Ustata", 25, 6, 182);
            Defender t2Defender3 = new Defender("Bosa", 28, 7, 185);
            Defender t2Defender4 = new Defender("Jameson", 30, 8, 178);
            Midfield t2Midfield1 = new Midfield("Dimitrov", 24, 9, 184);
            Midfield t2Midfield2 = new Midfield("Presiqn", 26, 10, 180);
            Midfield t2Midfield3 = new Midfield("Tomislav", 27, 12, 184);
            Striker t2Striker1 = new Striker("Fyre", 38, 11, 185);
            Striker t2Striker2 = new Striker("Andrew", 34, 13, 183);
            Striker t2Striker3 = new Striker("Victor", 41, 14, 181);

            List<FootbalPlayer> team2Players = new List<FootbalPlayer>
            {
                t2Goalkeeper,
                t2Defender1,
                t2Defender2,
                t2Defender3,
                t2Defender4,
                t2Midfield1,
                t2Midfield2,
                t2Midfield3,
                t2Striker1,
                t2Striker2,
                t2Striker3,
            };
            Team team2 = new Team(t2Coach, team2Players);
            Referee MainReferee = new Referee("Smoil", 37);
            Referee Assistant1 = new Referee("Stefanski", 35);
            Referee Assistant2 = new Referee("Zdravko", 34);

            Game game = new Game(team1, team2, MainReferee);
            game.AddGoal(10, t1Striker1);
            game.AddGoal(60, t1Striker2);
            game.AddGoal(90, t1Striker1);

            game.AddGoal(42, t2Striker1);
            game.AddGoal(70, t2Striker3);
            game.AddGoal(23, t2Striker3);
            game.PrintResult();
        }
    }
}
