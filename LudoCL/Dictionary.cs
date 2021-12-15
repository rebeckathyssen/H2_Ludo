using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoCL
{
    public class Dictionary
    {
        public Dictionary<int, List<int>> Map = new Dictionary<int, List<int>>();

        public Dictionary()
        {
            //Hearts - storage fields 
            List<int> field1coords = new List<int>();
            field1coords.Add(152);
            field1coords.Add(127);

            List<int> field2coords = new List<int>();
            field2coords.Add(220);
            field2coords.Add(127);

            List<int> field3coords = new List<int>();
            field3coords.Add(152);
            field3coords.Add(201);

            List<int> field4coords = new List<int>();
            field4coords.Add(220);
            field4coords.Add(201);

            //Hexagons - storage fields
            List<int> field5coords = new List<int>();
            field5coords.Add(530);
            field5coords.Add(127);

            List<int> field6coords = new List<int>();
            field6coords.Add(599);
            field6coords.Add(127);

            List<int> field7coords = new List<int>();
            field7coords.Add(530);
            field7coords.Add(198);

            List<int> field8coords = new List<int>();
            field8coords.Add(599);
            field8coords.Add(198);

            //Diamonds - storage fields
            List<int> field9coords = new List<int>();
            field9coords.Add(152);
            field9coords.Add(517);

            List<int> field10coords = new List<int>();
            field10coords.Add(220);
            field10coords.Add(517);

            List<int> field11coords = new List<int>();
            field11coords.Add(152);
            field11coords.Add(588);

            List<int> field12coords = new List<int>();
            field12coords.Add(220);
            field12coords.Add(588);

            //Stars - storage fields
            List<int> field13coords = new List<int>();
            field13coords.Add(532);
            field13coords.Add(515);

            List<int> field14coords = new List<int>();
            field14coords.Add(600);
            field14coords.Add(515);

            List<int> field15coords = new List<int>();
            field15coords.Add(531);
            field15coords.Add(588);

            List<int> field16coords = new List<int>();
            field16coords.Add(600);
            field16coords.Add(588);

            //When the game has begun...
            List<int> field17coords = new List<int>();
            field17coords.Add(81);
            field17coords.Add(314);

            List<int> field18coords = new List<int>();
            field18coords.Add(123);
            field18coords.Add(314);

            List<int> field19coords = new List<int>();
            field19coords.Add(164);
            field19coords.Add(314);

            List<int> field20coords = new List<int>();
            field20coords.Add(207);
            field20coords.Add(314);

            List<int> field21coords = new List<int>();
            field21coords.Add(250);
            field21coords.Add(314);

            List<int> field22coords = new List<int>();
            field22coords.Add(292);
            field22coords.Add(314);

            List<int> field23coords = new List<int>();
            field23coords.Add(334);
            field23coords.Add(314);

            List<int> field24coords = new List<int>();
            field24coords.Add(334);
            field24coords.Add(271);

            List<int> field25coords = new List<int>();
            field25coords.Add(334);
            field25coords.Add(228);

            List<int> field26coords = new List<int>();
            field26coords.Add(334);
            field26coords.Add(185);

            List<int> field27coords = new List<int>();
            field27coords.Add(334);
            field27coords.Add(141);

            List<int> field28coords = new List<int>();
            field28coords.Add(334);
            field28coords.Add(97);

            List<int> field29coords = new List<int>();
            field29coords.Add(334);
            field29coords.Add(55);

            List<int> field30coords = new List<int>();
            field30coords.Add(375);
            field30coords.Add(55);

            List<int> field31coords = new List<int>();
            field31coords.Add(418);
            field31coords.Add(55);

            List<int> field32coords = new List<int>();
            field32coords.Add(418);
            field32coords.Add(98);

            List<int> field33coords = new List<int>();
            field33coords.Add(418);
            field33coords.Add(141);

            List<int> field34coords = new List<int>();
            field34coords.Add(418);
            field34coords.Add(184);

            List<int> field35coords = new List<int>();
            field35coords.Add(418);
            field35coords.Add(228);

            List<int> field36coords = new List<int>();
            field36coords.Add(418);
            field36coords.Add(270);

            List<int> field37coords = new List<int>();
            field37coords.Add(418);
            field37coords.Add(314);

            List<int> field38coords = new List<int>();
            field38coords.Add(460);
            field38coords.Add(314);

            List<int> field39coords = new List<int>();
            field39coords.Add(502);
            field39coords.Add(314);

            List<int> field40coords = new List<int>();
            field40coords.Add(544);
            field40coords.Add(314);

            List<int> field41coords = new List<int>();
            field41coords.Add(586);
            field41coords.Add(314);

            List<int> field42coords = new List<int>();
            field42coords.Add(628);
            field42coords.Add(314);

            List<int> field43coords = new List<int>();
            field43coords.Add(670);
            field43coords.Add(314);

            List<int> field44coords = new List<int>();
            field44coords.Add(670);
            field44coords.Add(357);

            List<int> field45coords = new List<int>();
            field45coords.Add(670);
            field45coords.Add(401);

            List<int> field46coords = new List<int>();
            field46coords.Add(628);
            field46coords.Add(401);

            List<int> field47coords = new List<int>();
            field47coords.Add(586);
            field47coords.Add(401);

            List<int> field48coords = new List<int>();
            field48coords.Add(543);
            field48coords.Add(401);

            List<int> field49coords = new List<int>();
            field49coords.Add(501);
            field49coords.Add(401);

            List<int> field50coords = new List<int>();
            field50coords.Add(460);
            field50coords.Add(401);

            List<int> field51coords = new List<int>();
            field51coords.Add(418);
            field51coords.Add(401);

            List<int> field52coords = new List<int>();
            field52coords.Add(418);
            field52coords.Add(444);

            List<int> field53coords = new List<int>();
            field53coords.Add(418);
            field53coords.Add(489);

            List<int> field54coords = new List<int>();
            field54coords.Add(418);
            field54coords.Add(530);

            List<int> field55coords = new List<int>();
            field55coords.Add(418);
            field55coords.Add(574);

            List<int> field56coords = new List<int>();
            field56coords.Add(418);
            field56coords.Add(617);

            List<int> field57coords = new List<int>();
            field57coords.Add(418);
            field57coords.Add(660);

            List<int> field58coords = new List<int>();
            field58coords.Add(376);
            field58coords.Add(660);

            List<int> field59coords = new List<int>();
            field59coords.Add(335);
            field59coords.Add(660);

            List<int> field60coords = new List<int>();
            field60coords.Add(334);
            field60coords.Add(617);

            List<int> field61coords = new List<int>();
            field61coords.Add(334);
            field61coords.Add(574);

            List<int> field62coords = new List<int>();
            field62coords.Add(334);
            field62coords.Add(531);

            List<int> field63coords = new List<int>();
            field63coords.Add(334);
            field63coords.Add(487);

            List<int> field64coords = new List<int>();
            field64coords.Add(334);
            field64coords.Add(444);

            List<int> field65coords = new List<int>();
            field65coords.Add(334);
            field65coords.Add(401);

            List<int> field66coords = new List<int>();
            field66coords.Add(292);
            field66coords.Add(401);

            List<int> field67coords = new List<int>();
            field67coords.Add(249);
            field67coords.Add(401);

            List<int> field68coords = new List<int>();
            field68coords.Add(208);
            field68coords.Add(401);

            List<int> field69coords = new List<int>();
            field69coords.Add(165);
            field69coords.Add(401);

            List<int> field70coords = new List<int>();
            field70coords.Add(124);
            field70coords.Add(401);

            List<int> field71coords = new List<int>();
            field71coords.Add(82);
            field71coords.Add(401);

            List<int> field72coords = new List<int>();
            field72coords.Add(82);
            field72coords.Add(357);

            //Homerunner Red
            List<int> field73coords = new List<int>();
            field73coords.Add(124);
            field73coords.Add(357);

            List<int> field74coords = new List<int>();
            field74coords.Add(166);
            field74coords.Add(357);

            List<int> field75coords = new List<int>();
            field75coords.Add(208);
            field75coords.Add(357);

            List<int> field76coords = new List<int>();
            field76coords.Add(249);
            field76coords.Add(357);

            List<int> field77coords = new List<int>();
            field77coords.Add(291);
            field77coords.Add(357);

            List<int> field78coords = new List<int>();
            field78coords.Add(333);
            field78coords.Add(357);

            //Homerunner Turquoise
            List<int> field79coords = new List<int>();
            field79coords.Add(376);
            field79coords.Add(97);

            List<int> field80coords = new List<int>();
            field80coords.Add(376);
            field80coords.Add(140);

            List<int> field81coords = new List<int>();
            field81coords.Add(376);
            field81coords.Add(184);
            
            List<int> field82coords = new List<int>();
            field82coords.Add(376);
            field82coords.Add(227);
            
            List<int> field83coords = new List<int>();
            field83coords.Add(376);
            field83coords.Add(271);
            
            List<int> field84coords = new List<int>();
            field84coords.Add(376);
            field84coords.Add(314);

            //Homerunner Yellow
            List<int> field85coords = new List<int>();
            field85coords.Add(628);
            field85coords.Add(357);

            List<int> field86coords = new List<int>();
            field86coords.Add(586);
            field86coords.Add(357);

            List<int> field87coords = new List<int>();
            field87coords.Add(544);
            field87coords.Add(357);

            List<int> field88coords = new List<int>();
            field88coords.Add(501);
            field88coords.Add(357);

            List<int> field89coords = new List<int>();
            field89coords.Add(460);
            field89coords.Add(357);

            List<int> field90coords = new List<int>();
            field90coords.Add(418);
            field90coords.Add(357);

            //Homerunner Purple
            List<int> field91coords = new List<int>();
            field91coords.Add(376);
            field91coords.Add(617);

            List<int> field92coords = new List<int>();
            field92coords.Add(376);
            field92coords.Add(574);
            
            List<int> field93coords = new List<int>();
            field93coords.Add(376);
            field93coords.Add(531);
            
            List<int> field94coords = new List<int>();
            field94coords.Add(376);
            field94coords.Add(487);
            
            List<int> field95coords = new List<int>();
            field95coords.Add(376);
            field95coords.Add(444);
            
            List<int> field96coords = new List<int>();
            field96coords.Add(376);
            field96coords.Add(401);

            List<int> field97coords = new List<int>();
            field97coords.Add(376);
            field97coords.Add(357);


            //Add values to map
            Map.Add(0, field1coords);
            Map.Add(1, field2coords);
            Map.Add(2, field3coords);
            Map.Add(3, field4coords);
            Map.Add(4, field5coords);
            Map.Add(5, field6coords);
            Map.Add(6, field7coords);
            Map.Add(7, field8coords);
            Map.Add(8, field9coords);
            Map.Add(9, field10coords);
            Map.Add(10, field11coords);
            Map.Add(11, field12coords);
            Map.Add(12, field13coords);
            Map.Add(13, field14coords);
            Map.Add(14, field15coords);
            Map.Add(15, field16coords);
            Map.Add(16, field17coords);
            Map.Add(17, field18coords);
            Map.Add(18, field19coords);
            Map.Add(19, field20coords);
            Map.Add(20, field21coords);
            Map.Add(21, field22coords);
            Map.Add(22, field23coords);
            Map.Add(23, field24coords);
            Map.Add(24, field25coords);
            Map.Add(25, field26coords);
            Map.Add(26, field27coords);
            Map.Add(27, field28coords);
            Map.Add(28, field29coords);
            Map.Add(29, field30coords);
            Map.Add(30, field31coords);
            Map.Add(31, field32coords);
            Map.Add(32, field33coords);
            Map.Add(33, field34coords);
            Map.Add(34, field35coords);
            Map.Add(35, field36coords);
            Map.Add(36, field37coords);
            Map.Add(37, field38coords);
            Map.Add(38, field39coords);
            Map.Add(39, field40coords);
            Map.Add(40, field41coords);
            Map.Add(41, field42coords);
            Map.Add(42, field43coords);
            Map.Add(43, field44coords);
            Map.Add(44, field45coords);
            Map.Add(45, field46coords);
            Map.Add(46, field47coords);
            Map.Add(47, field48coords);
            Map.Add(48, field49coords);
            Map.Add(49, field50coords);
            Map.Add(50, field51coords);
            Map.Add(51, field52coords);
            Map.Add(52, field53coords);
            Map.Add(53, field54coords);
            Map.Add(54, field55coords);
            Map.Add(55, field56coords);
            Map.Add(56, field57coords);
            Map.Add(57, field58coords);
            Map.Add(58, field59coords);
            Map.Add(59, field60coords);
            Map.Add(60, field61coords);
            Map.Add(61, field62coords);
            Map.Add(62, field63coords);
            Map.Add(63, field64coords);
            Map.Add(64, field65coords);
            Map.Add(65, field66coords);
            Map.Add(66, field67coords);
            Map.Add(67, field68coords);
            Map.Add(68, field69coords);
            Map.Add(69, field70coords);
            Map.Add(70, field71coords);
            Map.Add(71, field72coords);
            Map.Add(72, field73coords);
            Map.Add(73, field74coords);
            Map.Add(74, field75coords);
            Map.Add(75, field76coords);
            Map.Add(76, field77coords);
            Map.Add(77, field78coords);
            Map.Add(78, field79coords);
            Map.Add(79, field80coords);
            Map.Add(80, field81coords);
            Map.Add(81, field82coords);
            Map.Add(82, field83coords);
            Map.Add(83, field84coords);
            Map.Add(84, field85coords);
            Map.Add(85, field86coords);
            Map.Add(86, field87coords);
            Map.Add(87, field88coords);
            Map.Add(88, field89coords);
            Map.Add(89, field90coords);
            Map.Add(90, field91coords);
            Map.Add(91, field92coords);
            Map.Add(92, field93coords);
            Map.Add(93, field94coords);
            Map.Add(94, field95coords);
            Map.Add(95, field96coords);
            Map.Add(96, field97coords);
        }
    }
}
