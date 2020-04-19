using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FF8_Memory_Reader
{
    public class FFVIIIMap
    {
        public Dictionary<int, int> locationList { get; }

        public FFVIIIMap()
        {
            //Map ID, Location ID. -1 = ???
            locationList = new Dictionary<int, int>();
            locationList.Add(0, -1);
            locationList.Add(1, -1);
            locationList.Add(2, -1);
            locationList.Add(3, -1);
            locationList.Add(4, -1);
            locationList.Add(5, -1);
            locationList.Add(6, -1);
            locationList.Add(7, -1);
            locationList.Add(8, -1);
            locationList.Add(9, -1);
            locationList.Add(10, -1);
            locationList.Add(11, -1);
            locationList.Add(12, -1);
            locationList.Add(13, -1);
            locationList.Add(14, -1);
            locationList.Add(15, -1);
            locationList.Add(16, -1);
            locationList.Add(17, -1);
            locationList.Add(18, -1);
            locationList.Add(19, -1);
            locationList.Add(20, -1);
            locationList.Add(21, -1);
            locationList.Add(22, -1);
            locationList.Add(23, -1);
            locationList.Add(24, -1);
            locationList.Add(25, -1);
            locationList.Add(26, -1);
            locationList.Add(27, -1);
            locationList.Add(28, -1);
            locationList.Add(29, -1);
            locationList.Add(30, -1);
            locationList.Add(31, -1);
            locationList.Add(32, -1);
            locationList.Add(33, -1);
            locationList.Add(34, -1);
            locationList.Add(35, -1);
            locationList.Add(36, -1);
            locationList.Add(37, -1);
            locationList.Add(38, -1);
            locationList.Add(39, -1);
            locationList.Add(40, -1);
            locationList.Add(41, -1);
            locationList.Add(42, -1);
            locationList.Add(43, -1);
            locationList.Add(44, -1);
            locationList.Add(45, -1);
            locationList.Add(46, -1);
            locationList.Add(47, -1);
            locationList.Add(48, -1);
            locationList.Add(49, -1);
            locationList.Add(50, -1);
            locationList.Add(51, -1);
            locationList.Add(52, -1);
            locationList.Add(53, -1);
            locationList.Add(54, -1);
            locationList.Add(55, -1);
            locationList.Add(56, -1);
            locationList.Add(57, -1);
            locationList.Add(58, -1);
            locationList.Add(59, -1);
            locationList.Add(60, -1);
            locationList.Add(61, -1);
            locationList.Add(62, -1);
            locationList.Add(63, -1);
            locationList.Add(64, -1);
            locationList.Add(65, -1);
            locationList.Add(66, -1);
            locationList.Add(67, -1);
            locationList.Add(68, -1);
            locationList.Add(69, -1);
            locationList.Add(70, -1);
            locationList.Add(71, -1);
            locationList.Add(72, -1);
            locationList.Add(73, -1);
            locationList.Add(74, -1);
            locationList.Add(75, -1);
            locationList.Add(76, -1);
            locationList.Add(77, -1);
            locationList.Add(78, -1);
            locationList.Add(79, -1);
            locationList.Add(80, -1);
            locationList.Add(81, -1);
            locationList.Add(82, -1);
            locationList.Add(83, -1);
            locationList.Add(84, -1);
            locationList.Add(85, -1);
            locationList.Add(86, -1);
            locationList.Add(87, -1);
            locationList.Add(88, -1);
            locationList.Add(89, -1);
            locationList.Add(90, -1);
            locationList.Add(91, -1);
            locationList.Add(92, -1);
            locationList.Add(93, -1);
            locationList.Add(94, -1);
            locationList.Add(95, -1);
            locationList.Add(96, -1);
            locationList.Add(97, -1);
            locationList.Add(98, -1);
            locationList.Add(99, -1);
            locationList.Add(100, -1);
            locationList.Add(101, -1);
            locationList.Add(102, 85);
            locationList.Add(103, 85);
            locationList.Add(104, 86);
            locationList.Add(105, 86);
            locationList.Add(106, 85);
            locationList.Add(107, 85);
            locationList.Add(108, 84);
            locationList.Add(109, 84);
            locationList.Add(110, 84);
            locationList.Add(111, 84);
            locationList.Add(112, 88);
            locationList.Add(113, 88);
            locationList.Add(114, 83);
            locationList.Add(115, 83);
            locationList.Add(116, 83);
            locationList.Add(117, 83);
            locationList.Add(118, 83);
            locationList.Add(119, 83);
            locationList.Add(120, 87);
            locationList.Add(121, 87);
            locationList.Add(122, 87);
            locationList.Add(123, 87);
            locationList.Add(124, 87);
            locationList.Add(125, 85);
            locationList.Add(126, 87);
            locationList.Add(127, 85);
            locationList.Add(128, 85);
            locationList.Add(129, 92);
            locationList.Add(130, 92);
            locationList.Add(131, 92);
            locationList.Add(132, 92);
            locationList.Add(133, 92);
            locationList.Add(134, 92);
            locationList.Add(135, 92);
            locationList.Add(136, 92);
            locationList.Add(137, 69);
            locationList.Add(138, 69);
            locationList.Add(139, 69);
            locationList.Add(140, 69);
            locationList.Add(141, 69);
            locationList.Add(142, 69);
            locationList.Add(143, 69);
            locationList.Add(144, 69);
            locationList.Add(145, 64);
            locationList.Add(146, 64);
            locationList.Add(147, 64);
            locationList.Add(148, 64);
            locationList.Add(149, 64);
            locationList.Add(150, 64);
            locationList.Add(151, 64);
            locationList.Add(152, -1);
            locationList.Add(153, -1);
            locationList.Add(154, 67);
            locationList.Add(155, 67);
            locationList.Add(156, 67);
            locationList.Add(157, 67);
            locationList.Add(158, 67);
            locationList.Add(159, 65);
            locationList.Add(160, 65);
            locationList.Add(161, 65);
            locationList.Add(162, 65);
            locationList.Add(163, 65);
            locationList.Add(164, 65);
            locationList.Add(165, 70);
            locationList.Add(166, 70);
            locationList.Add(167, 70);
            locationList.Add(168, 70);
            locationList.Add(169, 70);
            locationList.Add(170, 70);
            locationList.Add(171, 70);
            locationList.Add(172, 70);
            locationList.Add(173, 70);
            locationList.Add(174, 70);
            locationList.Add(175, 70);
            locationList.Add(176, 70);
            locationList.Add(177, 70);
            locationList.Add(178, 70);
            locationList.Add(179, 71);
            locationList.Add(180, 71);
            locationList.Add(181, 71);
            locationList.Add(182, 77);
            locationList.Add(183, 77);
            locationList.Add(184, 77);
            locationList.Add(185, 77);
            locationList.Add(186, 77);
            locationList.Add(187, 77);
            locationList.Add(188, 77);
            locationList.Add(189, 81);
            locationList.Add(190, 81);
            locationList.Add(191, 81);
            locationList.Add(192, 81);
            locationList.Add(193, 81);
            locationList.Add(194, 68);
            locationList.Add(195, 68);
            locationList.Add(196, 68);
            locationList.Add(197, 68);
            locationList.Add(198, 68);
            locationList.Add(199, 68);
            locationList.Add(200, 68);
            locationList.Add(201, 68);
            locationList.Add(202, 68);
            locationList.Add(203, 68);
            locationList.Add(204, 68);
            locationList.Add(205, 68);
            locationList.Add(206, 68);
            locationList.Add(207, 68);
            locationList.Add(208, 68);
            locationList.Add(209, 68);
            locationList.Add(210, 68);
            locationList.Add(211, 68);
            locationList.Add(212, 68);
            locationList.Add(213, 68);
            locationList.Add(214, 78);
            locationList.Add(215, 78);
            locationList.Add(216, 78);
            locationList.Add(217, 78);
            locationList.Add(218, 78);
            locationList.Add(219, 78);
            locationList.Add(220, 75);
            locationList.Add(221, 76);
            locationList.Add(222, 76);
            locationList.Add(223, -1);
            locationList.Add(224, 80);
            locationList.Add(225, 80);
            locationList.Add(226, 80);
            locationList.Add(227, 80);
            locationList.Add(228, 80);
            locationList.Add(229, 80);
            locationList.Add(230, 80);
            locationList.Add(231, 80);
            locationList.Add(232, 66);
            locationList.Add(233, 66);
            locationList.Add(234, 66);
            locationList.Add(235, 66);
            locationList.Add(236, 66);
            locationList.Add(237, 72);
            locationList.Add(238, 72);
            locationList.Add(239, 72);
            locationList.Add(240, 72);
            locationList.Add(241, 72);
            locationList.Add(242, 72);
            locationList.Add(243, 72);
            locationList.Add(244, 72);
            locationList.Add(245, 73);
            locationList.Add(246, 73);
            locationList.Add(247, 79);
            locationList.Add(248, 79);
            locationList.Add(249, 74);
            locationList.Add(250, 74);
            locationList.Add(251, 74);
            locationList.Add(252, 74);
            locationList.Add(253, 74);
            locationList.Add(254, 74);
            locationList.Add(255, 74);
            locationList.Add(256, 74);
            locationList.Add(257, 74);
            locationList.Add(258, 74);
            locationList.Add(259, 74);
            locationList.Add(260, -1);
            locationList.Add(261, -1);
            locationList.Add(262, 90);
            locationList.Add(263, 89);
            locationList.Add(264, 89);
            locationList.Add(265, 89);
            locationList.Add(266, 89);
            locationList.Add(267, 89);
            locationList.Add(268, 182);
            locationList.Add(269, 182);
            locationList.Add(270, 182);
            locationList.Add(271, 182);
            locationList.Add(272, 182);
            locationList.Add(273, 182);
            locationList.Add(274, 182);
            locationList.Add(275, 182);
            locationList.Add(276, 189);
            locationList.Add(277, 189);
            locationList.Add(278, 189);
            locationList.Add(279, 189);
            locationList.Add(280, 189);
            locationList.Add(281, 189);
            locationList.Add(282, 189);
            locationList.Add(283, 189);
            locationList.Add(284, 189);
            locationList.Add(285, 189);
            locationList.Add(286, 189);
            locationList.Add(287, 227);
            locationList.Add(288, 227);
            locationList.Add(289, 227);
            locationList.Add(290, 227);
            locationList.Add(291, 227);
            locationList.Add(292, 227);
            locationList.Add(293, 227);
            locationList.Add(294, 218);
            locationList.Add(295, 218);
            locationList.Add(296, 218);
            locationList.Add(297, 218);
            locationList.Add(298, 218);
            locationList.Add(299, 218);
            locationList.Add(300, 217);
            locationList.Add(301, 217);
            locationList.Add(302, 217);
            locationList.Add(303, 217);
            locationList.Add(304, 217);
            locationList.Add(305, 217);
            locationList.Add(306, 217);
            locationList.Add(307, 99);
            locationList.Add(308, 99);
            locationList.Add(309, 99);
            locationList.Add(310, 99);
            locationList.Add(311, 99);
            locationList.Add(312, 99);
            locationList.Add(313, 99);
            locationList.Add(314, 99);
            locationList.Add(315, 99);
            locationList.Add(316, 99);
            locationList.Add(317, 99);
            locationList.Add(318, 97);
            locationList.Add(319, 97);
            locationList.Add(320, 98);
            locationList.Add(321, 93);
            locationList.Add(322, 100);
            locationList.Add(323, 100);
            locationList.Add(324, 100);
            locationList.Add(325, 100);
            locationList.Add(326, 100);
            locationList.Add(327, 100);
            locationList.Add(328, 100);
            locationList.Add(329, 100);
            locationList.Add(330, 93);
            locationList.Add(331, 93);
            locationList.Add(332, 93);
            locationList.Add(333, 93);
            locationList.Add(334, 95);
            locationList.Add(335, 96);
            locationList.Add(336, 96);
            locationList.Add(337, 96);
            locationList.Add(338, 94);
            locationList.Add(339, 94);
            locationList.Add(340, 93);
            locationList.Add(341, 93);
            locationList.Add(342, 93);
            locationList.Add(343, 93);
            locationList.Add(344, 93);
            locationList.Add(345, 93);
            locationList.Add(346, 180);
            locationList.Add(347, -1);
            locationList.Add(348, 181);
            locationList.Add(349, 181);
            locationList.Add(350, 181);
            locationList.Add(351, 181);
            locationList.Add(352, 181);
            locationList.Add(353, 181);
            locationList.Add(354, 182);
            locationList.Add(355, 182);
            locationList.Add(356, 182);
            locationList.Add(357, 182);
            locationList.Add(358, 182);
            locationList.Add(359, 182);
            locationList.Add(360, 181);
            locationList.Add(361, 181);
            locationList.Add(362, 181);
            locationList.Add(363, 181);
            locationList.Add(364, 181);
            locationList.Add(365, 181);
            locationList.Add(366, 181);
            locationList.Add(367, 181);
            locationList.Add(368, 181);
            locationList.Add(369, 181);
            locationList.Add(370, 181);
            locationList.Add(371, 181);
            locationList.Add(372, 181);
            locationList.Add(373, 181);
            locationList.Add(374, 181);
            locationList.Add(375, 181);
            locationList.Add(376, 181);
            locationList.Add(377, 181);
            locationList.Add(378, 181);
            locationList.Add(379, 181);
            locationList.Add(380, 181);
            locationList.Add(381, 182);
            locationList.Add(382, 182);
            locationList.Add(383, 182);
            locationList.Add(384, 182);
            locationList.Add(385, 182);
            locationList.Add(386, 182);
            locationList.Add(387, 182);
            locationList.Add(388, 182);
            locationList.Add(389, 182);
            locationList.Add(390, 182);
            locationList.Add(391, 182);
            locationList.Add(392, 182);
            locationList.Add(393, 182);
            locationList.Add(394, 182);
            locationList.Add(395, 182);
            locationList.Add(396, 182);
            locationList.Add(397, 182);
            locationList.Add(398, 182);
            locationList.Add(399, 182);
            locationList.Add(400, 182);
            locationList.Add(401, 182);
            locationList.Add(402, 159);
            locationList.Add(403, 159);
            locationList.Add(404, 159);
            locationList.Add(405, 159);
            locationList.Add(406, 159);
            locationList.Add(407, 159);
            locationList.Add(408, 159);
            locationList.Add(409, 159);
            locationList.Add(410, 159);
            locationList.Add(411, 159);
            locationList.Add(412, 159);
            locationList.Add(413, 159);
            locationList.Add(414, 159);
            locationList.Add(415, 159);
            locationList.Add(416, 159);
            locationList.Add(417, 162);
            locationList.Add(418, 162);
            locationList.Add(419, 162);
            locationList.Add(420, 159);
            locationList.Add(421, 159);
            locationList.Add(422, 159);
            locationList.Add(423, 159);
            locationList.Add(424, 159);
            locationList.Add(425, 159);
            locationList.Add(426, 159);
            locationList.Add(427, 159);
            locationList.Add(428, 159);
            locationList.Add(429, 159);
            locationList.Add(430, 159);
            locationList.Add(431, 159);
            locationList.Add(432, 159);
            locationList.Add(433, 159);
            locationList.Add(434, 160);
            locationList.Add(435, 160);
            locationList.Add(436, 159);
            locationList.Add(437, 159);
            locationList.Add(438, 159);
            locationList.Add(439, 159);
            locationList.Add(440, 159);
            locationList.Add(441, 159);
            locationList.Add(442, 159);
            locationList.Add(443, 159);
            locationList.Add(444, 159);
            locationList.Add(445, 159);
            locationList.Add(446, 159);
            locationList.Add(447, 159);
            locationList.Add(448, 159);
            locationList.Add(449, 163);
            locationList.Add(450, 163);
            locationList.Add(451, 159);
            locationList.Add(452, 159);
            locationList.Add(453, 159);
            locationList.Add(454, 159);
            locationList.Add(455, 159);
            locationList.Add(456, 159);
            locationList.Add(457, 159);
            locationList.Add(458, 159);
            locationList.Add(459, 159);
            locationList.Add(460, 159);
            locationList.Add(461, 161);
            locationList.Add(462, 159);
            locationList.Add(463, 159);
            locationList.Add(464, 159);
            locationList.Add(465, 159);
            locationList.Add(466, 159);
            locationList.Add(467, 159);
            locationList.Add(468, 159);
            locationList.Add(469, 159);
            locationList.Add(470, 178);
            locationList.Add(471, 178);
            locationList.Add(472, 178);
            locationList.Add(473, 178);
            locationList.Add(474, 178);
            locationList.Add(475, 178);
            locationList.Add(476, 178);
            locationList.Add(477, 178);
            locationList.Add(478, 177);
            locationList.Add(479, 177);
            locationList.Add(480, 177);
            locationList.Add(481, 177);
            locationList.Add(482, 177);
            locationList.Add(483, 177);
            locationList.Add(484, 177);
            locationList.Add(485, 177);
            locationList.Add(486, 177);
            locationList.Add(487, 159);
            locationList.Add(488, 173);
            locationList.Add(489, 173);
            locationList.Add(490, 173);
            locationList.Add(491, 173);
            locationList.Add(492, 173);
            locationList.Add(493, 173);
            locationList.Add(494, 173);
            locationList.Add(495, 173);
            locationList.Add(496, 173);
            locationList.Add(497, 173);
            locationList.Add(498, 186);
            locationList.Add(499, 186);
            locationList.Add(500, 185);
            locationList.Add(501, 185);
            locationList.Add(502, 185);
            locationList.Add(503, 185);
            locationList.Add(504, 183);
            locationList.Add(505, 183);
            locationList.Add(506, 188);
            locationList.Add(507, 186);
            locationList.Add(508, 184);
            locationList.Add(509, 186);
            locationList.Add(510, 186);
            locationList.Add(511, 157);
            locationList.Add(512, 157);
            locationList.Add(513, 157);
            locationList.Add(514, 157);
            locationList.Add(515, 157);
            locationList.Add(516, 157);
            locationList.Add(517, 157);
            locationList.Add(518, 157);
            locationList.Add(519, 157);
            locationList.Add(520, 157);
            locationList.Add(521, 160);
            locationList.Add(522, 160);
            locationList.Add(523, 160);
            locationList.Add(524, 160);
            locationList.Add(525, 160);
            locationList.Add(526, 160);
            locationList.Add(527, 160);
            locationList.Add(528, 160);
            locationList.Add(529, 160);
            locationList.Add(530, 160);
            locationList.Add(531, 160);
            locationList.Add(532, 163);
            locationList.Add(533, 163);
            locationList.Add(534, 163);
            locationList.Add(535, 163);
            locationList.Add(536, 163);
            locationList.Add(537, 163);
            locationList.Add(538, 163);
            locationList.Add(539, 163);
            locationList.Add(540, 170);
            locationList.Add(541, 171);
            locationList.Add(542, 171);
            locationList.Add(543, 170);
            locationList.Add(544, 172);
            locationList.Add(545, 170);
            locationList.Add(546, 170);
            locationList.Add(547, 156);
            locationList.Add(548, 156);
            locationList.Add(549, 158);
            locationList.Add(550, 158);
            locationList.Add(551, 158);
            locationList.Add(552, 158);
            locationList.Add(553, 158);
            locationList.Add(554, 158);
            locationList.Add(555, 158);
            locationList.Add(556, 233);
            locationList.Add(557, 238);
            locationList.Add(558, 238);
            locationList.Add(559, 238);
            locationList.Add(560, 240);
            locationList.Add(561, 245);
            locationList.Add(562, 245);
            locationList.Add(563, 245);
            locationList.Add(564, 245);
            locationList.Add(565, 245);
            locationList.Add(566, 245);
            locationList.Add(567, 245);
            locationList.Add(568, 239);
            locationList.Add(569, 229);
            locationList.Add(570, 229);
            locationList.Add(571, 233);
            locationList.Add(572, 241);
            locationList.Add(573, 246);
            locationList.Add(574, 235);
            locationList.Add(575, 234);
            locationList.Add(576, 230);
            locationList.Add(577, 230);
            locationList.Add(578, 233);
            locationList.Add(579, 238);
            locationList.Add(580, 238);
            locationList.Add(581, 238);
            locationList.Add(582, 235);
            locationList.Add(583, 246);
            locationList.Add(584, 246);
            locationList.Add(585, 235);
            locationList.Add(586, 231);
            locationList.Add(587, 236);
            locationList.Add(588, 237);
            locationList.Add(589, 233);
            locationList.Add(590, 242);
            locationList.Add(591, 242);
            locationList.Add(592, 232);
            locationList.Add(593, 244);
            locationList.Add(594, 244);
            locationList.Add(595, 243);
            locationList.Add(596, 248);
            locationList.Add(597, 228);
            locationList.Add(598, 228);
            locationList.Add(599, 228);
            locationList.Add(600, 150);
            locationList.Add(601, 82);
            locationList.Add(602, 82);
            locationList.Add(603, 82);
            locationList.Add(604, 82);
            locationList.Add(605, 82);
            locationList.Add(606, 82);
            locationList.Add(607, 82);
            locationList.Add(608, 82);
            locationList.Add(609, 82);
            locationList.Add(610, 146);
            locationList.Add(611, 146);
            locationList.Add(612, 146);
            locationList.Add(613, 150);
            locationList.Add(614, 154);
            locationList.Add(615, 152);
            locationList.Add(616, 152);
            locationList.Add(617, 153);
            locationList.Add(618, 148);
            locationList.Add(619, 148);
            locationList.Add(620, 148);
            locationList.Add(621, 148);
            locationList.Add(622, 148);
            locationList.Add(623, 155);
            locationList.Add(624, 155);
            locationList.Add(625, 150);
            locationList.Add(626, 147);
            locationList.Add(627, 147);
            locationList.Add(628, 147);
            locationList.Add(629, 147);
            locationList.Add(630, 150);
            locationList.Add(631, 147);
            locationList.Add(632, 149);
            locationList.Add(633, 149);
            locationList.Add(634, 151);
            locationList.Add(635, 149);
            locationList.Add(636, 149);
            locationList.Add(637, 149);
            locationList.Add(638, 136);
            locationList.Add(639, 136);
            locationList.Add(640, 136);
            locationList.Add(641, 136);
            locationList.Add(642, 136);
            locationList.Add(643, 144);
            locationList.Add(644, 138);
            locationList.Add(645, 138);
            locationList.Add(646, 140);
            locationList.Add(647, 140);
            locationList.Add(648, 140);
            locationList.Add(649, 140);
            locationList.Add(650, 143);
            locationList.Add(651, 143);
            locationList.Add(652, 143);
            locationList.Add(653, 143);
            locationList.Add(654, 139);
            locationList.Add(655, 139);
            locationList.Add(656, 139);
            locationList.Add(657, 139);
            locationList.Add(658, 139);
            locationList.Add(659, 142);
            locationList.Add(660, 142);
            locationList.Add(661, 142);
            locationList.Add(662, 142);
            locationList.Add(663, 141);
            locationList.Add(664, 141);
            locationList.Add(665, 138);
            locationList.Add(666, 138);
            locationList.Add(667, 138);
            locationList.Add(668, 138);
            locationList.Add(669, 138);
            locationList.Add(670, 138);
            locationList.Add(671, 138);
            locationList.Add(672, 138);
            locationList.Add(673, 138);
            locationList.Add(674, 138);
            locationList.Add(675, 124);
            locationList.Add(676, 119);
            locationList.Add(677, 111);
            locationList.Add(678, 111);
            locationList.Add(679, 111);
            locationList.Add(680, 122);
            locationList.Add(681, 114);
            locationList.Add(682, 114);
            locationList.Add(683, 125);
            locationList.Add(684, 125);
            locationList.Add(685, 113);
            locationList.Add(686, 113);
            locationList.Add(687, 121);
            locationList.Add(688, 121);
            locationList.Add(689, 121);
            locationList.Add(690, 114);
            locationList.Add(691, 114);
            locationList.Add(692, 113);
            locationList.Add(693, 114);
            locationList.Add(694, 114);
            locationList.Add(695, 114);
            locationList.Add(696, 114);
            locationList.Add(697, 114);
            locationList.Add(698, 114);
            locationList.Add(699, 114);
            locationList.Add(700, 114);
            locationList.Add(701, 114);
            locationList.Add(702, 115);
            locationList.Add(703, 116);
            locationList.Add(704, 117);
            locationList.Add(705, 118);
            locationList.Add(706, 116);
            locationList.Add(707, 118);
            locationList.Add(708, 112);
            locationList.Add(709, 123);
            locationList.Add(710, -1);
            locationList.Add(711, 122);
            locationList.Add(712, 111);
            locationList.Add(713, 111);
            locationList.Add(714, 120);
            locationList.Add(715, 120);
            locationList.Add(716, 126);
            locationList.Add(717, 131);
            locationList.Add(718, -1);
            locationList.Add(719, 131);
            locationList.Add(720, 128);
            locationList.Add(721, 127);
            locationList.Add(722, 127);
            locationList.Add(723, 127);
            locationList.Add(724, 127);
            locationList.Add(725, 127);
            locationList.Add(726, 127);
            locationList.Add(727, 134);
            locationList.Add(728, 132);
            locationList.Add(729, 132);
            locationList.Add(730, 132);
            locationList.Add(731, 132);
            locationList.Add(732, 132);
            locationList.Add(733, 132);
            locationList.Add(734, 132);
            locationList.Add(735, 132);
            locationList.Add(736, 130);
            locationList.Add(737, 130);
            locationList.Add(738, 130);
            locationList.Add(739, 126);
            locationList.Add(740, 126);
            locationList.Add(741, 129);
            locationList.Add(742, 129);
            locationList.Add(743, 126);
            locationList.Add(744, 126);
            locationList.Add(745, 126);
            locationList.Add(746, 126);
            locationList.Add(747, 126);
            locationList.Add(748, 126);
            locationList.Add(749, 126);
            locationList.Add(750, 129);
            locationList.Add(751, 129);
            locationList.Add(752, 128);
            locationList.Add(753, 129);
            locationList.Add(754, 126);
            locationList.Add(755, 126);
            locationList.Add(756, 129);
            locationList.Add(757, 129);
            locationList.Add(758, 129);
            locationList.Add(759, 129);
            locationList.Add(760, 129);
            locationList.Add(761, 129);
            locationList.Add(762, 134);
            locationList.Add(763, 134);
            locationList.Add(764, 134);
            locationList.Add(765, 134);
            locationList.Add(766, 134);
            locationList.Add(767, 126);
            locationList.Add(768, 133);
            locationList.Add(769, 137);
            locationList.Add(770, 137);
            locationList.Add(771, 137);
            locationList.Add(772, 137);
            locationList.Add(773, 137);
            locationList.Add(774, 137);
            locationList.Add(775, 137);
            locationList.Add(776, 137);
            locationList.Add(777, 137);
            locationList.Add(778, 137);
            locationList.Add(779, 137);
            locationList.Add(780, 137);
            locationList.Add(781, 137);
            locationList.Add(782, 137);
            locationList.Add(783, 145);
            locationList.Add(784, 145);
            locationList.Add(785, 145);
            locationList.Add(786, 145);
            locationList.Add(787, 145);
            locationList.Add(788, 145);
            locationList.Add(789, 145);
            locationList.Add(790, 145);
            locationList.Add(791, 145);
            locationList.Add(792, 145);
            locationList.Add(793, 135);
            locationList.Add(794, 135);
            locationList.Add(795, 135);
            locationList.Add(796, 135);
            locationList.Add(797, 135);
            locationList.Add(798, 135);
            locationList.Add(799, 135);
            locationList.Add(800, 135);
            locationList.Add(801, 135);
            locationList.Add(802, 135);
            locationList.Add(803, 135);
            locationList.Add(804, 135);
            locationList.Add(805, 135);
            locationList.Add(806, 135);
            locationList.Add(807, 135);
            locationList.Add(808, 135);
            locationList.Add(809, 135);
            locationList.Add(810, 135);
            locationList.Add(811, 135);
            locationList.Add(812, 135);
            locationList.Add(813, 135);
            locationList.Add(814, 135);
            locationList.Add(815, 135);
            locationList.Add(816, 135);
            locationList.Add(817, 110);
            locationList.Add(818, 110);
            locationList.Add(819, 110);
            locationList.Add(820, 110);
            locationList.Add(821, 110);
            locationList.Add(822, 110);
            locationList.Add(823, 213);
            locationList.Add(824, 213);
            locationList.Add(825, 213);
            locationList.Add(826, 208);
            locationList.Add(827, 208);
            locationList.Add(828, 208);
            locationList.Add(829, 212);
            locationList.Add(830, 212);
            locationList.Add(831, 209);
            locationList.Add(832, 209);
            locationList.Add(833, 209);
            locationList.Add(834, 209);
            locationList.Add(835, 211);
            locationList.Add(836, 211);
            locationList.Add(837, 211);
            locationList.Add(838, 211);
            locationList.Add(839, 210);
            locationList.Add(840, 210);
            locationList.Add(841, 210);
            locationList.Add(842, 210);
            locationList.Add(843, 210);
            locationList.Add(844, 210);
            locationList.Add(845, 210);
            locationList.Add(846, 216);
            locationList.Add(847, 216);
            locationList.Add(848, 215);
            locationList.Add(849, 206);
            locationList.Add(850, 206);
            locationList.Add(851, 207);
            locationList.Add(852, 207);
            locationList.Add(853, 205);
            locationList.Add(854, 205);
            locationList.Add(855, 205);
            locationList.Add(856, 205);
            locationList.Add(857, 207);
            locationList.Add(858, 207);
            locationList.Add(859, 226);
            locationList.Add(860, 226);
            locationList.Add(861, 222);
            locationList.Add(862, 219);
            locationList.Add(863, 219);
            locationList.Add(864, 222);
            locationList.Add(865, 225);
            locationList.Add(866, 224);
            locationList.Add(867, 220);
            locationList.Add(868, 220);
            locationList.Add(869, 173);
            locationList.Add(870, 221);
            locationList.Add(871, 221);
            locationList.Add(872, 221);
            locationList.Add(873, 223);
            locationList.Add(874, 223);
            locationList.Add(875, 223);
            locationList.Add(876, 226);
            locationList.Add(877, 226);
            locationList.Add(878, 226);
            locationList.Add(879, 195);
            locationList.Add(880, 195);
            locationList.Add(881, 195);
            locationList.Add(882, 195);
            locationList.Add(883, 195);
            locationList.Add(884, 190);
            locationList.Add(885, 192);
            locationList.Add(886, 190);
            locationList.Add(887, 191);
            locationList.Add(888, 194);
            locationList.Add(889, 194);
            locationList.Add(890, 193);
            locationList.Add(891, 190);
            locationList.Add(892, 103);
            locationList.Add(893, 103);
            locationList.Add(894, 103);
            locationList.Add(895, 103);
            locationList.Add(896, 103);
            locationList.Add(897, 101);
            locationList.Add(898, 101);
            locationList.Add(899, 101);
            locationList.Add(900, 105);
            locationList.Add(901, 105);
            locationList.Add(902, 106);
            locationList.Add(903, 106);
            locationList.Add(904, 109);
            locationList.Add(905, 109);
            locationList.Add(906, 109);
            locationList.Add(907, 109);
            locationList.Add(908, 109);
            locationList.Add(909, 107);
            locationList.Add(910, 107);
            locationList.Add(911, 107);
            locationList.Add(912, 104);
            locationList.Add(913, 102);
            locationList.Add(914, 102);
            locationList.Add(915, 102);
            locationList.Add(916, 101);
            locationList.Add(917, 101);
            locationList.Add(918, 101);
            locationList.Add(919, 101);
            locationList.Add(920, 101);
            locationList.Add(921, 101);
            locationList.Add(922, 101);
            locationList.Add(923, 101);
            locationList.Add(924, 101);
            locationList.Add(925, 103);
            locationList.Add(926, 108);
            locationList.Add(927, 102);
            locationList.Add(928, 102);
            locationList.Add(929, 102);
            locationList.Add(930, 106);
            locationList.Add(931, 106);
            locationList.Add(932, 106);
            locationList.Add(933, 196);
            locationList.Add(934, 196);
            locationList.Add(935, 200);
            locationList.Add(936, 198);
            locationList.Add(937, 199);
            locationList.Add(938, 203);
            locationList.Add(939, 203);
            locationList.Add(940, 200);
            locationList.Add(941, 200);
            locationList.Add(942, 201);
            locationList.Add(943, 199);
            locationList.Add(944, 199);
            locationList.Add(945, 197);
            locationList.Add(946, 204);
            locationList.Add(947, 204);
            locationList.Add(948, 204);
            locationList.Add(949, 204);
            locationList.Add(950, 204);
            locationList.Add(951, -1);
            locationList.Add(952, -1);
            locationList.Add(953, -1);
            locationList.Add(954, -1);
            locationList.Add(955, -1);
            locationList.Add(956, -1);
            locationList.Add(957, -1);
            locationList.Add(958, -1);
            locationList.Add(959, -1);
            locationList.Add(960, -1);
            locationList.Add(961, -1);
            locationList.Add(962, -1);
            locationList.Add(963, -1);
            locationList.Add(964, -1);
            locationList.Add(965, 135);
            locationList.Add(966, 147);
            locationList.Add(967, 208);
            locationList.Add(968, 208);
            locationList.Add(969, 228);
            locationList.Add(970, 185);
            locationList.Add(971, 183);
            locationList.Add(972, 184);
            locationList.Add(973, 163);
            locationList.Add(974, -1);
            locationList.Add(975, -1);
            locationList.Add(976, 249);
            locationList.Add(977, -1);
            locationList.Add(978, -1);
            locationList.Add(979, 183);
            locationList.Add(980, -1);
            locationList.Add(981, -1);
        }

        public int getLocation(int mapId)
        {
            if (locationList.ContainsKey(mapId))
            {
                return locationList[mapId];
            }
            return -1;
        }
    }
}

/*
mapid   mapname     locationid
0	    wm00	
1	    wm01	
2	    wm02	
3	    wm03	
4	    wm04	
5	    wm05	
6	    wm06	
7	    wm07	
8	    wm08	
9	    wm09	
10	    wm10	
11	    wm11	
12	    wm12	
13	    wm13	
14	    wm14	
15	    wm15	
16	    wm16	
17	    wm17	
18	    wm18	
19	    wm19	
20	    wm20	
21	    wm21	
22	    wm22	
23	    wm23	
24	    wm24	
25	    wm25	
26	    wm26	
27	    wm27	
28	    wm28	
29	    wm29	
30	    wm30	
31	    wm31	
32	    wm32	
33	    wm33	
34	    wm34	
35	    wm35	
36	    wm36	
37	    wm37	
38	    wm38	
39	    wm39	
40	    wm40	
41	    wm41	
42	    wm42	
43	    wm43	
44	    wm44	
45	    wm45	
46	    wm46	
47	    wm47	
48	    wm48	
49	    wm49	
50	    wm50	
51	    wm51	
52	    wm52	
53	    wm53	
54	    wm54	
55	    wm55	
56	    wm56	
57	    wm57	
58	    wm58	
59	    wm59	
60	    wm60	
61	    wm61	
62	    wm62	
63	    wm63	
64	    wm64	
65	    wm65	
66	    wm66	
67	    wm67	
68	    wm68	
69	    wm69	
70	    wm70	
71	    wm71	
72	    testno	
73	    start	
74	    start0	
75	    gover	
76	    ending	
77	    test	
78	    test1	
79	    test2	
80	    test3	
81	    test4	
82	    test5	
83	    test6	
84	    test7	
85	    test8	
86	    test9	
87	    test13	
88	    test14	
89	    testbl0	
90	    testbl1	
91	    testbl2	
92	    testbl3	
93	    testbl4	
94	    testbl5	
95	    testbl6	
96	    testbl7	
97	    testbl8	
98	    testbl9	
99	    testbl13	
100	    testbl14	
101	    testmv	
102	    bccent_1	85
103	    bccent1a	85
104	    bcform_1	86
105	    bcform1a	86
106	    bcgate_1	85
107	    bcgate1a	85
108	    bchtl_1	    84
109	    bchtl1a	    84
110	    bchtr_1	    84
111	    bchtr1a	    84
112	    bcmin1_1	88
113	    bcmin11a	88
114	    bcmin2_1	83
115	    bcmin21a	83
116	    bcmin2_2	83
117	    bcmin22a	83
118	    bcmin2_3	83
119	    bcmin23a	83
120	    bcport_1	87
121	    bcport1a	87
122	    bcport1b	87
123	    bcport_2	87
124	    bcport2a	87
125	    bcsaka_1	85
126	    bcsaka1a	87
127	    bcsta_1	    85
128	    bcsta1a	    85
129	    bdenter1	92
130	    bdifrit1	92
131	    bdin1	    92
132	    bdin2	    92
133	    bdin3	    92
134	    bdin4	    92
135	    bdin5	    92
136	    bdview1	    92
137	    bg2f_1	    69
138	    bg2f_11	    69
139	    bg2f_2	    69
140	    bg2f_21	    69
141	    bg2f_4	    69
142	    bg2f_22	    69
143	    bg2f_3	    69
144	    bg2f_31	    69
145	    bgbook_1	64
146	    bgbook1a	64
147	    bgbook1b	64
148	    bgbook_2	64
149	    bgbook2a	64
150	    bgbook_3	64
151	    bgbook3a	64
152	    bgbtl_1	    
153	    bgcrash1	
154	    bgeat_1	    67
155	    bgeat1a	    67
156	    bgeat_2	    67
157	    bgeat2a	    67
158	    bgeat_3	    67
159	    bggate_1	65
160	    bggate_2	65
161	    bggate_4	65
162	    bggate_5	65
163	    bggate_6	65
164	    bggate6a	65
165	    bghall_1	70
166	    bghall1a	70
167	    bghall1b	70
168	    bghall_2	70
169	    bghall2a	70
170	    bghall_3	70
171	    bghall3a	70
172	    bghall_4	70
173	    bghall4a	70
174	    bghall_5	70
175	    bghall_6	70
176	    bghall6b	70
177	    bghall_7	70
178	    bghall_8	70
179	    bghoke_1	71
180	    bghoke_2	71
181	    bghoke_3	71
182	    bgkote_1	77
183	    bgkote1a	77
184	    bgkote_2	77
185	    bgkote_3	77
186	    bgkote3a	77
187	    bgkote_4	77
188	    bgkote_5	77
189	    bgmast_1	81
190	    bgmast_2	81
191	    bgmast_3	81
192	    bgmast_4	81
193	    bgmast_5	81
194	    bgmd1_1	    68
195	    bgmd1_2	    68
196	    bgmd1_3	    68
197	    bgmd1_4	    68
198	    bgmd2_1	    68
199	    bgmd2_3	    68
200	    bgmd2_4	    68
201	    bgmd2_5	    68
202	    bgmd2_6	    68
203	    bgmd2_7	    68
204	    bgmd2_8	    68
205	    bgmd3_1	    68
206	    bgmd3_2	    68
207	    bgmd4_1	    68
208	    bgmd4_2	    68
209	    bgmd4_3	    68
210	    bgmdele1	68
211	    bgmdele2	68
212	    bgmdele3	68
213	    bgmdele4	68
214	    bgmon_1	    78
215	    bgmon_2	    78
216	    bgmon_3	    78
217	    bgmon_4	    78
218	    bgmon_5	    78
219	    bgmon_6	    78
220	    bgpark_1	75
221	    bgpaty_1	76
222	    bgpaty_2	76
223	    bgrank1	    
224	    bgroad_1	80
225	    bgroad_2	80
226	    bgroad_3	80
227	    bgroad_4	80
228	    bgroad_5	80
229	    bgroad_6	80
230	    bgroad_7	80
231	    bgroad_9	80
232	    bgroom_1	66
233	    bgroom_3	66
234	    bgroom_4	66
235	    bgroom_5	66
236	    bgroom_6	66
237	    bgryo1_1	72
238	    bgryo1_2	72
239	    bgryo1_3	72
240	    bgryo1_4	72
241	    bgryo1_5	72
242	    bgryo1_6	72
243	    bgryo1_7	72
244	    bgryo1_8	72
245	    bgryo2_1	73
246	    bgryo2_2	73
247	    bgsecr_1	79
248	    bgsecr_2	79
249	    bgsido_1	74
250	    bgsido1a	74
251	    bgsido_2	74
252	    bgsido_3	74
253	    bgsido_4	74
254	    bgsido_5	74
255	    bgsido5a	74
256	    bgsido_6	74
257	    bgsido_7	74
258	    bgsido_8	74
259	    bgsido_9	74
260	    bvboat_1	
261	    bvboat_2	
262	    bvcar_1	    90
263	    bvtr_1	    89
264	    bvtr_2	    89
265	    bvtr_3	    89
266	    bvtr_4	    89
267	    bvtr_5	    89
268	    cdfield1	182
269	    cdfield2	182
270	    cdfield3	182
271	    cdfield4	182
272	    cdfield5	182
273	    cdfield6	182
274	    cdfield7	182
275	    cdfield8	182
276	    crenter1	189
277	    crodin1	    189
278	    cropen1	    189
279	    crpower1	189
280	    crroof1	    189
281	    crsanc1	    189
282	    crsphi1	    189
283	    crtower1	189
284	    crtower2	189
285	    crtower3	189
286	    crview1	    189
287	    cwwood1	    227
288	    cwwood2	    227
289	    cwwood3	    227
290	    cwwood4	    227
291	    cwwood5	    227
292	    cwwood6	    227
293	    cwwood7	    227
294	    ddruins1	218
295	    ddruins2	218
296	    ddruins3	218
297	    ddruins4	218
298	    ddruins5	218
299	    ddruins6	218
300	    ddsteam1	217
301	    ddtower1	217
302	    ddtower2	217
303	    ddtower3	217
304	    ddtower4	217
305	    ddtower5	217
306	    ddtower6	217
307	    doan1_1	    99
308	    doan1_2	    99
309	    doani1_1	99
310	    doani1_2	99
311	    doani3_1	99
312	    doani3_2	99
313	    doani4_1	99
314	    doani4_2	99
315	    dogate_1	99
316	    dogate1a	99
317	    dogate_2	99
318	    dohtl_1	    97
319	    dohtr_1	    97
320	    domin2_1	98
321	    domt1_1	    93
322	    domt2_1	    100
323	    domt3_1	    100
324	    domt3_2	    100
325	    domt3_3	    100
326	    domt3_4	    100
327	    domt4_1	    100
328	    domt5_1	    100
329	    domt6_1	    100
330	    doopen_1	93
331	    doopen1a	93
332	    doopen_2	93
333	    doopen2a	93
334	    doport_1	95
335	    dopub_1	    96
336	    dopub_2	    96
337	    dopub_3	    96
338	    dosea_1	    94
339	    dosea_2	    94
340	    dotown_1	93
341	    dotown1a	93
342	    dotown_2	93
343	    dotown2a	93
344	    dotown_3	93
345	    dotown3a	93
346	    eaplane1	180
347	    eapod1	    
348	    ebadele1	181
349	    ebadele2	181
350	    ebadele3	181
351	    ebadele5	181
352	    ebcont1	    181
353	    ebcont2	    181
354	    ebexit1	    182
355	    ebexit2	    182
356	    ebexit3	    182
357	    ebexit4	    182
358	    ebexit5	    182
359	    ebexit6	    182
360	    ebgate1	    181
361	    ebgate1a	181
362	    ebgate2	    181
363	    ebgate2a	181
364	    ebgate3	    181
365	    ebgate3a	181
366	    ebgate4	    181
367	    ebgate4a	181
368	    ebinhi1	    181
369	    ebinhi1a	181
370	    ebinlow1	181
371	    ebinlow2	181
372	    ebinmid1	181
373	    ebinmid4	181
374	    ebinmid2	181
375	    ebinmid5	181
376	    ebinmid3	181
377	    ebinmid6	181
378	    ebinto1	    181
379	    ebinto2	    181
380	    ebinto3	    181
381	    ebroad11	182
382	    ebroad12	182
383	    ebroad13	182
384	    ebroad21	182
385	    ebroad22	182
386	    ebroad23	182
387	    ebroad31	182
388	    ebroad32	182
389	    ebroad33	182
390	    ebroad41	182
391	    ebroad42	182
392	    ebroad43	182
393	    ebroad5	    182
394	    ebroad6	    182
395	    ebroad6a	182
396	    ebroad7	    182
397	    ebroad7a	182
398	    ebroad8	    182
399	    ebroad8a	182
400	    ebroad9	    182
401	    ebroad9a	182
402	    eccway11	159
403	    eccway15	159
404	    eccway12	159
405	    eccway16	159
406	    eccway13	159
407	    eccway14	159
408	    eccway21	159
409	    eccway22	159
410	    eccway23	159
411	    eccway31	159
412	    eccway32	159
413	    eccway33	159
414	    eccway41	159
415	    eccway42	159
416	    eccway43	159
417	    ecenc1	    162
418	    ecenc2	    162
419	    ecenc3	    162
420	    ecenter1	159
421	    ecenter4	159
422	    ecenter2	159
423	    ecenter5	159
424	    ecenter3	159
425	    eciway11	159
426	    eciway15	159
427	    eciway12	159
428	    eciway16	159
429	    eciway13	159
430	    eciway14	159
431	    ecmall1	    159
432	    ecmall1a	159
433	    ecmall1b	159
434	    ecmview1	160
435	    ecmview2	160
436	    ecmview3	159
437	    ecmway1	    159
438	    ecmway1a	159
439	    ecmway1b	159
440	    ecopen1	    159
441	    ecopen1a	159
442	    ecopen1b	159
443	    ecopen2	    159
444	    ecopen2a	159
445	    ecopen2b	159
446	    ecopen3	    159
447	    ecopen3a	159
448	    ecopen3b	159
449	    ecopen4	    163
450	    ecopen4a	163
451	    ecopen4b	159
452	    ecoway1	    159
453	    ecoway1a	159
454	    ecoway1b	159
455	    ecoway2	    159
456	    ecoway2a	159
457	    ecoway2b	159
458	    ecoway3	    159
459	    ecoway3a	159
460	    ecoway3b	159
461	    ecpview1	161
462	    ecpview2	159
463	    ecpview3	159
464	    ecpway1	    159
465	    ecpway1a	159
466	    ecpway1b	159
467	    ectake1	    159
468	    ectake2	    159
469	    ectake3	    159
470	    edlabo1	    178
471	    edlabo1a	178
472	    edlabo1b	178
473	    edmoor1	    178
474	    edview1	    178
475	    edview1a	178
476	    edview1b	178
477	    edview2	    178
478	    eein1	    177
479	    eein11	    177
480	    eein12	    177
481	    eein3	    177
482	    eein31	    177
483	    eein32	    177
484	    eeview1	    177
485	    eeview2	    177
486	    eeview3	    177
487	    efbig1	    159
488	    efenter1	173
489	    efenter2	173
490	    efenter3	173
491	    efpod1	    173
492	    efpod1a	    173
493	    efpod1b	    173
494	    efview1	    173
495	    efview1a	173
496	    efview1b	173
497	    efview2	    173
498	    ehback1	    186
499	    ehback2	    186
500	    ehblan1	    185
501	    ehblan2	    185
502	    ehblan3	    185
503	    ehdrug1	    185
504	    ehenter1	183
505	    ehenter2	183
506	    ehhana1	    188
507	    ehnoki1	    186
508	    ehroom1	    184
509	    ehsea1	    186
510	    ehsea2	    186
511	    elroad1	    157
512	    elroad2	    157
513	    elroad3	    157
514	    elstop1	    157
515	    elview1	    157
516	    elview2	    157
517	    elwall1	    157
518	    elwall2	    157
519	    elwall3	    157
520	    elwall4	    157
521	    embind1	    160
522	    embind1a	160
523	    embind2	    160
524	    emlabo1	    160
525	    emlabo1a	160
526	    emlabo1b	160
527	    emlabo2	    160
528	    emlobby1	160
529	    emlobby3	160
530	    emlobby2	160
531	    emlobby4	160
532	    ephall1	    163
533	    ephall2	    163
534	    epmeet1	    163
535	    eproad1	    163
536	    eproad2	    163
537	    epwork1	    163
538	    epwork2	    163
539	    epwork3	    163
540	    escont1	    170
541	    escouse1	171
542	    escouse2	171
543	    esform1	    170
544	    esfreez1	172
545	    esview1	    170
546	    esview2	    170
547	    etsta1	    156
548	    etsta2	    156
549	    ewbrdg1	    158
550	    ewdoor1	    158
551	    ewele1	    158
552	    ewele2	    158
553	    ewele3	    158
554	    ewpanel1	158
555	    ewpanel2	158
556	    fe2f1	    233
557	    feart1f1	238
558	    feart1f2	238
559	    feart2f1	238
560	    febarac1	240
561	    febrdg1	    245
562	    feclock1	245
563	    feclock2	245
564	    feclock3	245
565	    feclock4	245
566	    feclock5	245
567	    feclock6	245
568	    fegate1	    239
569	    fehall1	    229
570	    fehall2	    229
571	    fein1	    233
572	    fejail1	    241
573	    felast1	    246
574	    felfst1	    235
575	    felrele1	234
576	    feopen1	    230
577	    feopen2	    230
578	    feout1	    233
579	    fepic1	    238
580	    fepic2	    238
581	    fepic3	    238
582	    ferfst1	    235
583	    feroad1	    246
584	    feroad2	    246
585	    ferrst1	    235
586	    feteras1	231
587	    fetre1	    236
588	    feware1	    237
589	    fewater1	233
590	    fewater2	242
591	    fewater3	242
592	    fewine1	    232
593	    fewor1	    244
594	    fewor2	    244
595	    feyard1	    243
596	    ffbrdg1	    248
597	    ffhill1	    228
598	    ffhole1	    228
599	    ffseed1	    228
600	    fhbrdg1	    150
601	    fhdeck1	    82
602	    fhdeck2	    82
603	    fhdeck3	    82
604	    fhdeck4	    82
605	    fhdeck4a	82
606	    fhdeck5	    82
607	    fhdeck6	    82
608	    fhdeck7	    82
609	    fhdeck7a	82
610	    fhedge1	    146
611	    fhedge11	146
612	    fhedge2	    146
613	    fhfish1	    150
614	    fhform1	    154
615	    fhhtl1	    152
616	    fhhtr1	    152
617	    fhmin1	    153
618	    fhpanel1	148
619	    fhpara11	148
620	    fhpara12	148
621	    fhparar1	148
622	    fhparar2	148
623	    fhrail2	    155
624	    fhrail3	    155
625	    fhroof1	    150
626	    fhtown1	    147
627	    fhtown21	147
628	    fhtown22	147
629	    fhtown23	147
630	    fhview1	    150
631	    fhwater1	147
632	    fhwise11	149
633	    fhwise12	149
634	    fhwise13	151
635	    fhwise15	149
636	    fhwisef1	149
637	    fhwisef2	149
638	    gdsand1	    136
639	    gdsand2	    136
640	    gdsand3	    136
641	    gdsta1	    136
642	    gdtrain1	136
643	    gfcar1	    144
644	    gfcross1	138
645	    gfcross2	138
646	    gfelone1	140
647	    gfelone3	140
648	    gfelone2	140
649	    gfelone4	140
650	    gfhtl1	    143
651	    gfhtl1a	    143
652	    gfhtr1	    143
653	    gfhtr1a	    143
654	    gflain1	    139
655	    gflain1a	139
656	    gflain11	139
657	    gflain2	    139
658	    gflain2a	139
659	    gfmin1	    142
660	    gfmin1a	    142
661	    gfmin2	    142
662	    gfmin2a	    142
663	    gfrich1	    141
664	    gfrich1a	141
665	    gfview1	    138
666	    gfview1a	138
667	    gfvill1	    138
668	    gfvill1a	138
669	    gfvill21	138
670	    gfvill24	138
671	    gfvill22	138
672	    gfvill23	138
673	    gfvill31	138
674	    gfvill32	138
675	    ggback1	    124
676	    ggele1	    119
677	    gggate1	    111
678	    gggate2	    111
679	    gggate3	    111
680	    gggro1	    122
681	    gggroen1	114
682	    gggroen2	114
683	    gggym1	    125
684	    gggym2	    125
685	    gghall1	    113
686	    gghall2	    113
687	    ggkodo1	    121
688	    ggkodo2	    121
689	    ggkodo4	    121
690	    ggroad1	    114
691	    ggroad2	    114
692	    ggroad3	    113
693	    ggroad5	    114
694	    ggroad6	    114
695	    ggroad7	    114
696	    ggroad8	    114
697	    ggroad8a	114
698	    ggroad8b	114
699	    ggroad9	    114
700	    ggroad9a	114
701	    ggroad9b	114
702	    ggroom1	    115
703	    ggroom2	    116
704	    ggroom3	    117
705	    ggroom4	    118
706	    ggroom6	    116
707	    ggroom7	    118
708	    ggsta1	    112
709	    ggstaen1	123
710	    ggstaen3	
711	    ggstand1	122
712	    ggview1	    111
713	    ggview2	    111
714	    ggwitch1	120
715	    ggwitch2	120
716	    glclock1	126
717	    glclub1	    131
718	    glclub3	    
719	    glclub4	    131
720	    glform1	    128
721	    glfurin1	127
722	    glfurin4	127
723	    glfurin5	127
724	    glfurin2	127
725	    glfurin3	127
726	    glfury1	    127
727	    glfuryb1	134
728	    glgate1	    132
729	    glgate2	    132
730	    glgate2a	132
731	    glgate3	    132
732	    glgate3a	132
733	    glgateb1	132
734	    glgatei1	132
735	    glgatei2	132
736	    glhtl1	    130
737	    glhtr1	    130
738	    glhtr1a	    130
739	    glkara1	    126
740	    glkara2	    126
741	    glmall1	    129
742	    glmall2	    129
743	    glprefr1	126
744	    glprefr2	126
745	    glprefr3	126
746	    glprein1	126
747	    glpreo1	    126
748	    glpreo2	    126
749	    glpreo3	    126
750	    glrent1	    129
751	    glroad1	    129
752	    glsta1	    128
753	    glsta2	    129
754	    glstage1	126
755	    glstage3	126
756	    glstaup1	129
757	    glstaup4	129
758	    glstaup2	129
759	    glstaup5	129
760	    glstaup3	129
761	    gltown1	    129
762	    glwater1	134
763	    glwater2	134
764	    glwater3	134
765	    glwater4	134
766	    glwater5	134
767	    glwitch1	126
768	    glyagu1	    133
769	    gmcont1	    137
770	    gmcont2	    137
771	    gmden1	    137
772	    gmhouse1	137
773	    gmmoni1	    137
774	    gmout1	    137
775	    gmpark1	    137
776	    gmpark2	    137
777	    gmshoot1	137
778	    gmtika1	    137
779	    gmtika2	    137
780	    gmtika3	    137
781	    gmtika4	    137
782	    gmtika5	    137
783	    gnroad1	    145
784	    gnroad2	    145
785	    gnroad3	    145
786	    gnroad4	    145
787	    gnroad5	    145
788	    gnroom1	    145
789	    gnroom2	    145
790	    gnroom3	    145
791	    gnroom4	    145
792	    gnview1	    145
793	    gparm1	    135
794	    gpbig1	    135
795	    gpbig1a	    135
796	    gpbig2	    135
797	    gpbig2a	    135
798	    gpbig3	    135
799	    gpbigin1	135
800	    gpbigin3	135
801	    gpbigin2	135
802	    gpbigin4	135
803	    gpbigin5	135
804	    gpcell1	    135
805	    gpcont1	    135
806	    gpcont2	    135
807	    gpescap1	135
808	    gpexit1	    135
809	    gpexit2	    135
810	    gpgmn1	    135
811	    gpgmn1a	    135
812	    gpgmn2	    135
813	    gpgmn3	    135
814	    gppark1	    135
815	    gproof1	    135
816	    gproof2	    135
817	    gwbrook1	110
818	    gwenter1	110
819	    gwgrass1	110
820	    gwpool1	    110
821	    gwpool2	    110
822	    gwroad1	    110
823	    rgair1	    213
824	    rgair2	    213
825	    rgair3	    213
826	    rgcock1	    208
827	    rgcock2	    208
828	    rgcock3	    208
829	    rgexit1	    212
830	    rgexit2	    212
831	    rgguest1	209
832	    rgguest2	209
833	    rgguest3	209
834	    rgguest4	209
835	    rgguest5	211
836	    rghang1	    211
837	    rghang11	211
838	    rghang2	    211
839	    rghatch1	210
840	    rgroad1	    210
841	    rgroad11	210
842	    rgroad2	    210
843	    rgroad21	210
844	    rgroad3	    210
845	    rgroad31	210
846	    sdcore1	    216
847	    sdcore2	    216
848	    sdisle1	    215
849	    seback1	    206
850	    seback2	    206
851	    secont1	    207
852	    secont2	    207
853	    sefront1	205
854	    sefront2	205
855	    sefront3	205
856	    sefront4	205
857	    seroom1	    207
858	    seroom2	    207
859	    ssadel1	    226
860	    ssadel2	    226
861	    ssblock1	222
862	    sscont1	    219
863	    sscont2	    219
864	    ssdock1	    222
865	    sselone1	225
866	    sslock1	    224
867	    ssmedi1	    220
868	    ssmedi2	    220
869	    sspack1	    173
870	    sspod1	    221
871	    sspod2	    221
872	    sspod3	    221
873	    ssroad1	    223
874	    ssroad2	    223
875	    ssroad3	    223
876	    ssspace1	226
877	    ssspace2	226
878	    ssspace3	226
879	    tgcourt1	195
880	    tgcourt5	195
881	    tgcourt2	195
882	    tgcourt3	195
883	    tgcourt4	195
884	    tgfront1	190
885	    tggara1	    192
886	    tggate1	    190
887	    tggrave1	191
888	    tgroom1	    194
889	    tgroom2	    194
890	    tgstage1	193
891	    tgview1	    190
892	    tiagit1	    103
893	    tiagit2	    103
894	    tiagit3	    103
895	    tiagit4	    103
896	    tiagit5	    103
897	    tiback1	    101
898	    tiback2	    101
899	    tigate1	    101
900	    tihtl1	    105
901	    tihtr1	    105
902	    tilink1	    106
903	    tilink2	    106
904	    timania1	109
905	    timania2	109
906	    timania3	109
907	    timania4	109
908	    timania5	109
909	    timin1	    107
910	    timin21	    107
911	    timin22	    107
912	    tipub1	    104
913	    tistud1	    102
914	    tistud21	102
915	    tistud22	102
916	    titown1	    101
917	    titown2	    101
918	    titown3	    101
919	    titown4	    101
920	    titown51	101
921	    titown52	101
922	    titown6	    101
923	    titown7	    101
924	    titown8	    101
925	    titrain1	103
926	    titv1	    108
927	    titvout1	102
928	    tivisi1	    102
929	    tivisi2	    102
930	    tiyane1	    106
931	    tiyane2	    106
932	    tiyane3	    106
933	    tmdome1	    196
934	    tmdome2	    196
935	    tmelder1	200
936	    tmele1	    198
937	    tmgate1	    199
938	    tmhtl1	    203
939	    tmhtr1	    203
940	    tmkobo1	    200
941	    tmkobo2	    200
942	    tmmin1	    201
943	    tmmura1	    199
944	    tmmura2	    199
945	    tmsand1	    197
946	    tvglen1	    204
947	    tvglen2	    204
948	    tvglen3	    204
949	    tvglen4	    204
950	    tvglen5	    204
951	    laguna01	
952	    laguna02	
953	    laguna03	
954	    laguna04	
955	    laguna05	
956	    laguna06	
957	    laguna07	
958	    laguna08	
959	    laguna09	
960	    laguna10	
961	    laguna11	
962	    laguna12	
963	    laguna13	
964	    laguna14	
965	    gpbigin6	135
966	    fhtown24	147
967	    rgcock4	    208
968	    rgcock5	    208
969	    ffhole1a	228
970	    ehblan1a	185
971	    ehenter3	183
972	    ehroom1a	184
973	    eproad1a	163
974	    fewhite1	
975	    feblack1	
976	    glwitch3	249
977	    ehback1a	
978	    ehblan1b	
979	    ehenter4	183
980	    ehroom1b	
981	    ehsea1a	    
*/