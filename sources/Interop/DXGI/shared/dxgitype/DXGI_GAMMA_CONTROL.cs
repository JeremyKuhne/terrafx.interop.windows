// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct DXGI_GAMMA_CONTROL
    {
        public DXGI_RGB Scale;

        public DXGI_RGB Offset;

        [NativeTypeName("DXGI_RGB [1025]")]
        public _GammaCurve_e__FixedBuffer GammaCurve;

        public partial struct _GammaCurve_e__FixedBuffer
        {
            internal DXGI_RGB e0;
            internal DXGI_RGB e1;
            internal DXGI_RGB e2;
            internal DXGI_RGB e3;
            internal DXGI_RGB e4;
            internal DXGI_RGB e5;
            internal DXGI_RGB e6;
            internal DXGI_RGB e7;
            internal DXGI_RGB e8;
            internal DXGI_RGB e9;
            internal DXGI_RGB e10;
            internal DXGI_RGB e11;
            internal DXGI_RGB e12;
            internal DXGI_RGB e13;
            internal DXGI_RGB e14;
            internal DXGI_RGB e15;
            internal DXGI_RGB e16;
            internal DXGI_RGB e17;
            internal DXGI_RGB e18;
            internal DXGI_RGB e19;
            internal DXGI_RGB e20;
            internal DXGI_RGB e21;
            internal DXGI_RGB e22;
            internal DXGI_RGB e23;
            internal DXGI_RGB e24;
            internal DXGI_RGB e25;
            internal DXGI_RGB e26;
            internal DXGI_RGB e27;
            internal DXGI_RGB e28;
            internal DXGI_RGB e29;
            internal DXGI_RGB e30;
            internal DXGI_RGB e31;
            internal DXGI_RGB e32;
            internal DXGI_RGB e33;
            internal DXGI_RGB e34;
            internal DXGI_RGB e35;
            internal DXGI_RGB e36;
            internal DXGI_RGB e37;
            internal DXGI_RGB e38;
            internal DXGI_RGB e39;
            internal DXGI_RGB e40;
            internal DXGI_RGB e41;
            internal DXGI_RGB e42;
            internal DXGI_RGB e43;
            internal DXGI_RGB e44;
            internal DXGI_RGB e45;
            internal DXGI_RGB e46;
            internal DXGI_RGB e47;
            internal DXGI_RGB e48;
            internal DXGI_RGB e49;
            internal DXGI_RGB e50;
            internal DXGI_RGB e51;
            internal DXGI_RGB e52;
            internal DXGI_RGB e53;
            internal DXGI_RGB e54;
            internal DXGI_RGB e55;
            internal DXGI_RGB e56;
            internal DXGI_RGB e57;
            internal DXGI_RGB e58;
            internal DXGI_RGB e59;
            internal DXGI_RGB e60;
            internal DXGI_RGB e61;
            internal DXGI_RGB e62;
            internal DXGI_RGB e63;
            internal DXGI_RGB e64;
            internal DXGI_RGB e65;
            internal DXGI_RGB e66;
            internal DXGI_RGB e67;
            internal DXGI_RGB e68;
            internal DXGI_RGB e69;
            internal DXGI_RGB e70;
            internal DXGI_RGB e71;
            internal DXGI_RGB e72;
            internal DXGI_RGB e73;
            internal DXGI_RGB e74;
            internal DXGI_RGB e75;
            internal DXGI_RGB e76;
            internal DXGI_RGB e77;
            internal DXGI_RGB e78;
            internal DXGI_RGB e79;
            internal DXGI_RGB e80;
            internal DXGI_RGB e81;
            internal DXGI_RGB e82;
            internal DXGI_RGB e83;
            internal DXGI_RGB e84;
            internal DXGI_RGB e85;
            internal DXGI_RGB e86;
            internal DXGI_RGB e87;
            internal DXGI_RGB e88;
            internal DXGI_RGB e89;
            internal DXGI_RGB e90;
            internal DXGI_RGB e91;
            internal DXGI_RGB e92;
            internal DXGI_RGB e93;
            internal DXGI_RGB e94;
            internal DXGI_RGB e95;
            internal DXGI_RGB e96;
            internal DXGI_RGB e97;
            internal DXGI_RGB e98;
            internal DXGI_RGB e99;
            internal DXGI_RGB e100;
            internal DXGI_RGB e101;
            internal DXGI_RGB e102;
            internal DXGI_RGB e103;
            internal DXGI_RGB e104;
            internal DXGI_RGB e105;
            internal DXGI_RGB e106;
            internal DXGI_RGB e107;
            internal DXGI_RGB e108;
            internal DXGI_RGB e109;
            internal DXGI_RGB e110;
            internal DXGI_RGB e111;
            internal DXGI_RGB e112;
            internal DXGI_RGB e113;
            internal DXGI_RGB e114;
            internal DXGI_RGB e115;
            internal DXGI_RGB e116;
            internal DXGI_RGB e117;
            internal DXGI_RGB e118;
            internal DXGI_RGB e119;
            internal DXGI_RGB e120;
            internal DXGI_RGB e121;
            internal DXGI_RGB e122;
            internal DXGI_RGB e123;
            internal DXGI_RGB e124;
            internal DXGI_RGB e125;
            internal DXGI_RGB e126;
            internal DXGI_RGB e127;
            internal DXGI_RGB e128;
            internal DXGI_RGB e129;
            internal DXGI_RGB e130;
            internal DXGI_RGB e131;
            internal DXGI_RGB e132;
            internal DXGI_RGB e133;
            internal DXGI_RGB e134;
            internal DXGI_RGB e135;
            internal DXGI_RGB e136;
            internal DXGI_RGB e137;
            internal DXGI_RGB e138;
            internal DXGI_RGB e139;
            internal DXGI_RGB e140;
            internal DXGI_RGB e141;
            internal DXGI_RGB e142;
            internal DXGI_RGB e143;
            internal DXGI_RGB e144;
            internal DXGI_RGB e145;
            internal DXGI_RGB e146;
            internal DXGI_RGB e147;
            internal DXGI_RGB e148;
            internal DXGI_RGB e149;
            internal DXGI_RGB e150;
            internal DXGI_RGB e151;
            internal DXGI_RGB e152;
            internal DXGI_RGB e153;
            internal DXGI_RGB e154;
            internal DXGI_RGB e155;
            internal DXGI_RGB e156;
            internal DXGI_RGB e157;
            internal DXGI_RGB e158;
            internal DXGI_RGB e159;
            internal DXGI_RGB e160;
            internal DXGI_RGB e161;
            internal DXGI_RGB e162;
            internal DXGI_RGB e163;
            internal DXGI_RGB e164;
            internal DXGI_RGB e165;
            internal DXGI_RGB e166;
            internal DXGI_RGB e167;
            internal DXGI_RGB e168;
            internal DXGI_RGB e169;
            internal DXGI_RGB e170;
            internal DXGI_RGB e171;
            internal DXGI_RGB e172;
            internal DXGI_RGB e173;
            internal DXGI_RGB e174;
            internal DXGI_RGB e175;
            internal DXGI_RGB e176;
            internal DXGI_RGB e177;
            internal DXGI_RGB e178;
            internal DXGI_RGB e179;
            internal DXGI_RGB e180;
            internal DXGI_RGB e181;
            internal DXGI_RGB e182;
            internal DXGI_RGB e183;
            internal DXGI_RGB e184;
            internal DXGI_RGB e185;
            internal DXGI_RGB e186;
            internal DXGI_RGB e187;
            internal DXGI_RGB e188;
            internal DXGI_RGB e189;
            internal DXGI_RGB e190;
            internal DXGI_RGB e191;
            internal DXGI_RGB e192;
            internal DXGI_RGB e193;
            internal DXGI_RGB e194;
            internal DXGI_RGB e195;
            internal DXGI_RGB e196;
            internal DXGI_RGB e197;
            internal DXGI_RGB e198;
            internal DXGI_RGB e199;
            internal DXGI_RGB e200;
            internal DXGI_RGB e201;
            internal DXGI_RGB e202;
            internal DXGI_RGB e203;
            internal DXGI_RGB e204;
            internal DXGI_RGB e205;
            internal DXGI_RGB e206;
            internal DXGI_RGB e207;
            internal DXGI_RGB e208;
            internal DXGI_RGB e209;
            internal DXGI_RGB e210;
            internal DXGI_RGB e211;
            internal DXGI_RGB e212;
            internal DXGI_RGB e213;
            internal DXGI_RGB e214;
            internal DXGI_RGB e215;
            internal DXGI_RGB e216;
            internal DXGI_RGB e217;
            internal DXGI_RGB e218;
            internal DXGI_RGB e219;
            internal DXGI_RGB e220;
            internal DXGI_RGB e221;
            internal DXGI_RGB e222;
            internal DXGI_RGB e223;
            internal DXGI_RGB e224;
            internal DXGI_RGB e225;
            internal DXGI_RGB e226;
            internal DXGI_RGB e227;
            internal DXGI_RGB e228;
            internal DXGI_RGB e229;
            internal DXGI_RGB e230;
            internal DXGI_RGB e231;
            internal DXGI_RGB e232;
            internal DXGI_RGB e233;
            internal DXGI_RGB e234;
            internal DXGI_RGB e235;
            internal DXGI_RGB e236;
            internal DXGI_RGB e237;
            internal DXGI_RGB e238;
            internal DXGI_RGB e239;
            internal DXGI_RGB e240;
            internal DXGI_RGB e241;
            internal DXGI_RGB e242;
            internal DXGI_RGB e243;
            internal DXGI_RGB e244;
            internal DXGI_RGB e245;
            internal DXGI_RGB e246;
            internal DXGI_RGB e247;
            internal DXGI_RGB e248;
            internal DXGI_RGB e249;
            internal DXGI_RGB e250;
            internal DXGI_RGB e251;
            internal DXGI_RGB e252;
            internal DXGI_RGB e253;
            internal DXGI_RGB e254;
            internal DXGI_RGB e255;
            internal DXGI_RGB e256;
            internal DXGI_RGB e257;
            internal DXGI_RGB e258;
            internal DXGI_RGB e259;
            internal DXGI_RGB e260;
            internal DXGI_RGB e261;
            internal DXGI_RGB e262;
            internal DXGI_RGB e263;
            internal DXGI_RGB e264;
            internal DXGI_RGB e265;
            internal DXGI_RGB e266;
            internal DXGI_RGB e267;
            internal DXGI_RGB e268;
            internal DXGI_RGB e269;
            internal DXGI_RGB e270;
            internal DXGI_RGB e271;
            internal DXGI_RGB e272;
            internal DXGI_RGB e273;
            internal DXGI_RGB e274;
            internal DXGI_RGB e275;
            internal DXGI_RGB e276;
            internal DXGI_RGB e277;
            internal DXGI_RGB e278;
            internal DXGI_RGB e279;
            internal DXGI_RGB e280;
            internal DXGI_RGB e281;
            internal DXGI_RGB e282;
            internal DXGI_RGB e283;
            internal DXGI_RGB e284;
            internal DXGI_RGB e285;
            internal DXGI_RGB e286;
            internal DXGI_RGB e287;
            internal DXGI_RGB e288;
            internal DXGI_RGB e289;
            internal DXGI_RGB e290;
            internal DXGI_RGB e291;
            internal DXGI_RGB e292;
            internal DXGI_RGB e293;
            internal DXGI_RGB e294;
            internal DXGI_RGB e295;
            internal DXGI_RGB e296;
            internal DXGI_RGB e297;
            internal DXGI_RGB e298;
            internal DXGI_RGB e299;
            internal DXGI_RGB e300;
            internal DXGI_RGB e301;
            internal DXGI_RGB e302;
            internal DXGI_RGB e303;
            internal DXGI_RGB e304;
            internal DXGI_RGB e305;
            internal DXGI_RGB e306;
            internal DXGI_RGB e307;
            internal DXGI_RGB e308;
            internal DXGI_RGB e309;
            internal DXGI_RGB e310;
            internal DXGI_RGB e311;
            internal DXGI_RGB e312;
            internal DXGI_RGB e313;
            internal DXGI_RGB e314;
            internal DXGI_RGB e315;
            internal DXGI_RGB e316;
            internal DXGI_RGB e317;
            internal DXGI_RGB e318;
            internal DXGI_RGB e319;
            internal DXGI_RGB e320;
            internal DXGI_RGB e321;
            internal DXGI_RGB e322;
            internal DXGI_RGB e323;
            internal DXGI_RGB e324;
            internal DXGI_RGB e325;
            internal DXGI_RGB e326;
            internal DXGI_RGB e327;
            internal DXGI_RGB e328;
            internal DXGI_RGB e329;
            internal DXGI_RGB e330;
            internal DXGI_RGB e331;
            internal DXGI_RGB e332;
            internal DXGI_RGB e333;
            internal DXGI_RGB e334;
            internal DXGI_RGB e335;
            internal DXGI_RGB e336;
            internal DXGI_RGB e337;
            internal DXGI_RGB e338;
            internal DXGI_RGB e339;
            internal DXGI_RGB e340;
            internal DXGI_RGB e341;
            internal DXGI_RGB e342;
            internal DXGI_RGB e343;
            internal DXGI_RGB e344;
            internal DXGI_RGB e345;
            internal DXGI_RGB e346;
            internal DXGI_RGB e347;
            internal DXGI_RGB e348;
            internal DXGI_RGB e349;
            internal DXGI_RGB e350;
            internal DXGI_RGB e351;
            internal DXGI_RGB e352;
            internal DXGI_RGB e353;
            internal DXGI_RGB e354;
            internal DXGI_RGB e355;
            internal DXGI_RGB e356;
            internal DXGI_RGB e357;
            internal DXGI_RGB e358;
            internal DXGI_RGB e359;
            internal DXGI_RGB e360;
            internal DXGI_RGB e361;
            internal DXGI_RGB e362;
            internal DXGI_RGB e363;
            internal DXGI_RGB e364;
            internal DXGI_RGB e365;
            internal DXGI_RGB e366;
            internal DXGI_RGB e367;
            internal DXGI_RGB e368;
            internal DXGI_RGB e369;
            internal DXGI_RGB e370;
            internal DXGI_RGB e371;
            internal DXGI_RGB e372;
            internal DXGI_RGB e373;
            internal DXGI_RGB e374;
            internal DXGI_RGB e375;
            internal DXGI_RGB e376;
            internal DXGI_RGB e377;
            internal DXGI_RGB e378;
            internal DXGI_RGB e379;
            internal DXGI_RGB e380;
            internal DXGI_RGB e381;
            internal DXGI_RGB e382;
            internal DXGI_RGB e383;
            internal DXGI_RGB e384;
            internal DXGI_RGB e385;
            internal DXGI_RGB e386;
            internal DXGI_RGB e387;
            internal DXGI_RGB e388;
            internal DXGI_RGB e389;
            internal DXGI_RGB e390;
            internal DXGI_RGB e391;
            internal DXGI_RGB e392;
            internal DXGI_RGB e393;
            internal DXGI_RGB e394;
            internal DXGI_RGB e395;
            internal DXGI_RGB e396;
            internal DXGI_RGB e397;
            internal DXGI_RGB e398;
            internal DXGI_RGB e399;
            internal DXGI_RGB e400;
            internal DXGI_RGB e401;
            internal DXGI_RGB e402;
            internal DXGI_RGB e403;
            internal DXGI_RGB e404;
            internal DXGI_RGB e405;
            internal DXGI_RGB e406;
            internal DXGI_RGB e407;
            internal DXGI_RGB e408;
            internal DXGI_RGB e409;
            internal DXGI_RGB e410;
            internal DXGI_RGB e411;
            internal DXGI_RGB e412;
            internal DXGI_RGB e413;
            internal DXGI_RGB e414;
            internal DXGI_RGB e415;
            internal DXGI_RGB e416;
            internal DXGI_RGB e417;
            internal DXGI_RGB e418;
            internal DXGI_RGB e419;
            internal DXGI_RGB e420;
            internal DXGI_RGB e421;
            internal DXGI_RGB e422;
            internal DXGI_RGB e423;
            internal DXGI_RGB e424;
            internal DXGI_RGB e425;
            internal DXGI_RGB e426;
            internal DXGI_RGB e427;
            internal DXGI_RGB e428;
            internal DXGI_RGB e429;
            internal DXGI_RGB e430;
            internal DXGI_RGB e431;
            internal DXGI_RGB e432;
            internal DXGI_RGB e433;
            internal DXGI_RGB e434;
            internal DXGI_RGB e435;
            internal DXGI_RGB e436;
            internal DXGI_RGB e437;
            internal DXGI_RGB e438;
            internal DXGI_RGB e439;
            internal DXGI_RGB e440;
            internal DXGI_RGB e441;
            internal DXGI_RGB e442;
            internal DXGI_RGB e443;
            internal DXGI_RGB e444;
            internal DXGI_RGB e445;
            internal DXGI_RGB e446;
            internal DXGI_RGB e447;
            internal DXGI_RGB e448;
            internal DXGI_RGB e449;
            internal DXGI_RGB e450;
            internal DXGI_RGB e451;
            internal DXGI_RGB e452;
            internal DXGI_RGB e453;
            internal DXGI_RGB e454;
            internal DXGI_RGB e455;
            internal DXGI_RGB e456;
            internal DXGI_RGB e457;
            internal DXGI_RGB e458;
            internal DXGI_RGB e459;
            internal DXGI_RGB e460;
            internal DXGI_RGB e461;
            internal DXGI_RGB e462;
            internal DXGI_RGB e463;
            internal DXGI_RGB e464;
            internal DXGI_RGB e465;
            internal DXGI_RGB e466;
            internal DXGI_RGB e467;
            internal DXGI_RGB e468;
            internal DXGI_RGB e469;
            internal DXGI_RGB e470;
            internal DXGI_RGB e471;
            internal DXGI_RGB e472;
            internal DXGI_RGB e473;
            internal DXGI_RGB e474;
            internal DXGI_RGB e475;
            internal DXGI_RGB e476;
            internal DXGI_RGB e477;
            internal DXGI_RGB e478;
            internal DXGI_RGB e479;
            internal DXGI_RGB e480;
            internal DXGI_RGB e481;
            internal DXGI_RGB e482;
            internal DXGI_RGB e483;
            internal DXGI_RGB e484;
            internal DXGI_RGB e485;
            internal DXGI_RGB e486;
            internal DXGI_RGB e487;
            internal DXGI_RGB e488;
            internal DXGI_RGB e489;
            internal DXGI_RGB e490;
            internal DXGI_RGB e491;
            internal DXGI_RGB e492;
            internal DXGI_RGB e493;
            internal DXGI_RGB e494;
            internal DXGI_RGB e495;
            internal DXGI_RGB e496;
            internal DXGI_RGB e497;
            internal DXGI_RGB e498;
            internal DXGI_RGB e499;
            internal DXGI_RGB e500;
            internal DXGI_RGB e501;
            internal DXGI_RGB e502;
            internal DXGI_RGB e503;
            internal DXGI_RGB e504;
            internal DXGI_RGB e505;
            internal DXGI_RGB e506;
            internal DXGI_RGB e507;
            internal DXGI_RGB e508;
            internal DXGI_RGB e509;
            internal DXGI_RGB e510;
            internal DXGI_RGB e511;
            internal DXGI_RGB e512;
            internal DXGI_RGB e513;
            internal DXGI_RGB e514;
            internal DXGI_RGB e515;
            internal DXGI_RGB e516;
            internal DXGI_RGB e517;
            internal DXGI_RGB e518;
            internal DXGI_RGB e519;
            internal DXGI_RGB e520;
            internal DXGI_RGB e521;
            internal DXGI_RGB e522;
            internal DXGI_RGB e523;
            internal DXGI_RGB e524;
            internal DXGI_RGB e525;
            internal DXGI_RGB e526;
            internal DXGI_RGB e527;
            internal DXGI_RGB e528;
            internal DXGI_RGB e529;
            internal DXGI_RGB e530;
            internal DXGI_RGB e531;
            internal DXGI_RGB e532;
            internal DXGI_RGB e533;
            internal DXGI_RGB e534;
            internal DXGI_RGB e535;
            internal DXGI_RGB e536;
            internal DXGI_RGB e537;
            internal DXGI_RGB e538;
            internal DXGI_RGB e539;
            internal DXGI_RGB e540;
            internal DXGI_RGB e541;
            internal DXGI_RGB e542;
            internal DXGI_RGB e543;
            internal DXGI_RGB e544;
            internal DXGI_RGB e545;
            internal DXGI_RGB e546;
            internal DXGI_RGB e547;
            internal DXGI_RGB e548;
            internal DXGI_RGB e549;
            internal DXGI_RGB e550;
            internal DXGI_RGB e551;
            internal DXGI_RGB e552;
            internal DXGI_RGB e553;
            internal DXGI_RGB e554;
            internal DXGI_RGB e555;
            internal DXGI_RGB e556;
            internal DXGI_RGB e557;
            internal DXGI_RGB e558;
            internal DXGI_RGB e559;
            internal DXGI_RGB e560;
            internal DXGI_RGB e561;
            internal DXGI_RGB e562;
            internal DXGI_RGB e563;
            internal DXGI_RGB e564;
            internal DXGI_RGB e565;
            internal DXGI_RGB e566;
            internal DXGI_RGB e567;
            internal DXGI_RGB e568;
            internal DXGI_RGB e569;
            internal DXGI_RGB e570;
            internal DXGI_RGB e571;
            internal DXGI_RGB e572;
            internal DXGI_RGB e573;
            internal DXGI_RGB e574;
            internal DXGI_RGB e575;
            internal DXGI_RGB e576;
            internal DXGI_RGB e577;
            internal DXGI_RGB e578;
            internal DXGI_RGB e579;
            internal DXGI_RGB e580;
            internal DXGI_RGB e581;
            internal DXGI_RGB e582;
            internal DXGI_RGB e583;
            internal DXGI_RGB e584;
            internal DXGI_RGB e585;
            internal DXGI_RGB e586;
            internal DXGI_RGB e587;
            internal DXGI_RGB e588;
            internal DXGI_RGB e589;
            internal DXGI_RGB e590;
            internal DXGI_RGB e591;
            internal DXGI_RGB e592;
            internal DXGI_RGB e593;
            internal DXGI_RGB e594;
            internal DXGI_RGB e595;
            internal DXGI_RGB e596;
            internal DXGI_RGB e597;
            internal DXGI_RGB e598;
            internal DXGI_RGB e599;
            internal DXGI_RGB e600;
            internal DXGI_RGB e601;
            internal DXGI_RGB e602;
            internal DXGI_RGB e603;
            internal DXGI_RGB e604;
            internal DXGI_RGB e605;
            internal DXGI_RGB e606;
            internal DXGI_RGB e607;
            internal DXGI_RGB e608;
            internal DXGI_RGB e609;
            internal DXGI_RGB e610;
            internal DXGI_RGB e611;
            internal DXGI_RGB e612;
            internal DXGI_RGB e613;
            internal DXGI_RGB e614;
            internal DXGI_RGB e615;
            internal DXGI_RGB e616;
            internal DXGI_RGB e617;
            internal DXGI_RGB e618;
            internal DXGI_RGB e619;
            internal DXGI_RGB e620;
            internal DXGI_RGB e621;
            internal DXGI_RGB e622;
            internal DXGI_RGB e623;
            internal DXGI_RGB e624;
            internal DXGI_RGB e625;
            internal DXGI_RGB e626;
            internal DXGI_RGB e627;
            internal DXGI_RGB e628;
            internal DXGI_RGB e629;
            internal DXGI_RGB e630;
            internal DXGI_RGB e631;
            internal DXGI_RGB e632;
            internal DXGI_RGB e633;
            internal DXGI_RGB e634;
            internal DXGI_RGB e635;
            internal DXGI_RGB e636;
            internal DXGI_RGB e637;
            internal DXGI_RGB e638;
            internal DXGI_RGB e639;
            internal DXGI_RGB e640;
            internal DXGI_RGB e641;
            internal DXGI_RGB e642;
            internal DXGI_RGB e643;
            internal DXGI_RGB e644;
            internal DXGI_RGB e645;
            internal DXGI_RGB e646;
            internal DXGI_RGB e647;
            internal DXGI_RGB e648;
            internal DXGI_RGB e649;
            internal DXGI_RGB e650;
            internal DXGI_RGB e651;
            internal DXGI_RGB e652;
            internal DXGI_RGB e653;
            internal DXGI_RGB e654;
            internal DXGI_RGB e655;
            internal DXGI_RGB e656;
            internal DXGI_RGB e657;
            internal DXGI_RGB e658;
            internal DXGI_RGB e659;
            internal DXGI_RGB e660;
            internal DXGI_RGB e661;
            internal DXGI_RGB e662;
            internal DXGI_RGB e663;
            internal DXGI_RGB e664;
            internal DXGI_RGB e665;
            internal DXGI_RGB e666;
            internal DXGI_RGB e667;
            internal DXGI_RGB e668;
            internal DXGI_RGB e669;
            internal DXGI_RGB e670;
            internal DXGI_RGB e671;
            internal DXGI_RGB e672;
            internal DXGI_RGB e673;
            internal DXGI_RGB e674;
            internal DXGI_RGB e675;
            internal DXGI_RGB e676;
            internal DXGI_RGB e677;
            internal DXGI_RGB e678;
            internal DXGI_RGB e679;
            internal DXGI_RGB e680;
            internal DXGI_RGB e681;
            internal DXGI_RGB e682;
            internal DXGI_RGB e683;
            internal DXGI_RGB e684;
            internal DXGI_RGB e685;
            internal DXGI_RGB e686;
            internal DXGI_RGB e687;
            internal DXGI_RGB e688;
            internal DXGI_RGB e689;
            internal DXGI_RGB e690;
            internal DXGI_RGB e691;
            internal DXGI_RGB e692;
            internal DXGI_RGB e693;
            internal DXGI_RGB e694;
            internal DXGI_RGB e695;
            internal DXGI_RGB e696;
            internal DXGI_RGB e697;
            internal DXGI_RGB e698;
            internal DXGI_RGB e699;
            internal DXGI_RGB e700;
            internal DXGI_RGB e701;
            internal DXGI_RGB e702;
            internal DXGI_RGB e703;
            internal DXGI_RGB e704;
            internal DXGI_RGB e705;
            internal DXGI_RGB e706;
            internal DXGI_RGB e707;
            internal DXGI_RGB e708;
            internal DXGI_RGB e709;
            internal DXGI_RGB e710;
            internal DXGI_RGB e711;
            internal DXGI_RGB e712;
            internal DXGI_RGB e713;
            internal DXGI_RGB e714;
            internal DXGI_RGB e715;
            internal DXGI_RGB e716;
            internal DXGI_RGB e717;
            internal DXGI_RGB e718;
            internal DXGI_RGB e719;
            internal DXGI_RGB e720;
            internal DXGI_RGB e721;
            internal DXGI_RGB e722;
            internal DXGI_RGB e723;
            internal DXGI_RGB e724;
            internal DXGI_RGB e725;
            internal DXGI_RGB e726;
            internal DXGI_RGB e727;
            internal DXGI_RGB e728;
            internal DXGI_RGB e729;
            internal DXGI_RGB e730;
            internal DXGI_RGB e731;
            internal DXGI_RGB e732;
            internal DXGI_RGB e733;
            internal DXGI_RGB e734;
            internal DXGI_RGB e735;
            internal DXGI_RGB e736;
            internal DXGI_RGB e737;
            internal DXGI_RGB e738;
            internal DXGI_RGB e739;
            internal DXGI_RGB e740;
            internal DXGI_RGB e741;
            internal DXGI_RGB e742;
            internal DXGI_RGB e743;
            internal DXGI_RGB e744;
            internal DXGI_RGB e745;
            internal DXGI_RGB e746;
            internal DXGI_RGB e747;
            internal DXGI_RGB e748;
            internal DXGI_RGB e749;
            internal DXGI_RGB e750;
            internal DXGI_RGB e751;
            internal DXGI_RGB e752;
            internal DXGI_RGB e753;
            internal DXGI_RGB e754;
            internal DXGI_RGB e755;
            internal DXGI_RGB e756;
            internal DXGI_RGB e757;
            internal DXGI_RGB e758;
            internal DXGI_RGB e759;
            internal DXGI_RGB e760;
            internal DXGI_RGB e761;
            internal DXGI_RGB e762;
            internal DXGI_RGB e763;
            internal DXGI_RGB e764;
            internal DXGI_RGB e765;
            internal DXGI_RGB e766;
            internal DXGI_RGB e767;
            internal DXGI_RGB e768;
            internal DXGI_RGB e769;
            internal DXGI_RGB e770;
            internal DXGI_RGB e771;
            internal DXGI_RGB e772;
            internal DXGI_RGB e773;
            internal DXGI_RGB e774;
            internal DXGI_RGB e775;
            internal DXGI_RGB e776;
            internal DXGI_RGB e777;
            internal DXGI_RGB e778;
            internal DXGI_RGB e779;
            internal DXGI_RGB e780;
            internal DXGI_RGB e781;
            internal DXGI_RGB e782;
            internal DXGI_RGB e783;
            internal DXGI_RGB e784;
            internal DXGI_RGB e785;
            internal DXGI_RGB e786;
            internal DXGI_RGB e787;
            internal DXGI_RGB e788;
            internal DXGI_RGB e789;
            internal DXGI_RGB e790;
            internal DXGI_RGB e791;
            internal DXGI_RGB e792;
            internal DXGI_RGB e793;
            internal DXGI_RGB e794;
            internal DXGI_RGB e795;
            internal DXGI_RGB e796;
            internal DXGI_RGB e797;
            internal DXGI_RGB e798;
            internal DXGI_RGB e799;
            internal DXGI_RGB e800;
            internal DXGI_RGB e801;
            internal DXGI_RGB e802;
            internal DXGI_RGB e803;
            internal DXGI_RGB e804;
            internal DXGI_RGB e805;
            internal DXGI_RGB e806;
            internal DXGI_RGB e807;
            internal DXGI_RGB e808;
            internal DXGI_RGB e809;
            internal DXGI_RGB e810;
            internal DXGI_RGB e811;
            internal DXGI_RGB e812;
            internal DXGI_RGB e813;
            internal DXGI_RGB e814;
            internal DXGI_RGB e815;
            internal DXGI_RGB e816;
            internal DXGI_RGB e817;
            internal DXGI_RGB e818;
            internal DXGI_RGB e819;
            internal DXGI_RGB e820;
            internal DXGI_RGB e821;
            internal DXGI_RGB e822;
            internal DXGI_RGB e823;
            internal DXGI_RGB e824;
            internal DXGI_RGB e825;
            internal DXGI_RGB e826;
            internal DXGI_RGB e827;
            internal DXGI_RGB e828;
            internal DXGI_RGB e829;
            internal DXGI_RGB e830;
            internal DXGI_RGB e831;
            internal DXGI_RGB e832;
            internal DXGI_RGB e833;
            internal DXGI_RGB e834;
            internal DXGI_RGB e835;
            internal DXGI_RGB e836;
            internal DXGI_RGB e837;
            internal DXGI_RGB e838;
            internal DXGI_RGB e839;
            internal DXGI_RGB e840;
            internal DXGI_RGB e841;
            internal DXGI_RGB e842;
            internal DXGI_RGB e843;
            internal DXGI_RGB e844;
            internal DXGI_RGB e845;
            internal DXGI_RGB e846;
            internal DXGI_RGB e847;
            internal DXGI_RGB e848;
            internal DXGI_RGB e849;
            internal DXGI_RGB e850;
            internal DXGI_RGB e851;
            internal DXGI_RGB e852;
            internal DXGI_RGB e853;
            internal DXGI_RGB e854;
            internal DXGI_RGB e855;
            internal DXGI_RGB e856;
            internal DXGI_RGB e857;
            internal DXGI_RGB e858;
            internal DXGI_RGB e859;
            internal DXGI_RGB e860;
            internal DXGI_RGB e861;
            internal DXGI_RGB e862;
            internal DXGI_RGB e863;
            internal DXGI_RGB e864;
            internal DXGI_RGB e865;
            internal DXGI_RGB e866;
            internal DXGI_RGB e867;
            internal DXGI_RGB e868;
            internal DXGI_RGB e869;
            internal DXGI_RGB e870;
            internal DXGI_RGB e871;
            internal DXGI_RGB e872;
            internal DXGI_RGB e873;
            internal DXGI_RGB e874;
            internal DXGI_RGB e875;
            internal DXGI_RGB e876;
            internal DXGI_RGB e877;
            internal DXGI_RGB e878;
            internal DXGI_RGB e879;
            internal DXGI_RGB e880;
            internal DXGI_RGB e881;
            internal DXGI_RGB e882;
            internal DXGI_RGB e883;
            internal DXGI_RGB e884;
            internal DXGI_RGB e885;
            internal DXGI_RGB e886;
            internal DXGI_RGB e887;
            internal DXGI_RGB e888;
            internal DXGI_RGB e889;
            internal DXGI_RGB e890;
            internal DXGI_RGB e891;
            internal DXGI_RGB e892;
            internal DXGI_RGB e893;
            internal DXGI_RGB e894;
            internal DXGI_RGB e895;
            internal DXGI_RGB e896;
            internal DXGI_RGB e897;
            internal DXGI_RGB e898;
            internal DXGI_RGB e899;
            internal DXGI_RGB e900;
            internal DXGI_RGB e901;
            internal DXGI_RGB e902;
            internal DXGI_RGB e903;
            internal DXGI_RGB e904;
            internal DXGI_RGB e905;
            internal DXGI_RGB e906;
            internal DXGI_RGB e907;
            internal DXGI_RGB e908;
            internal DXGI_RGB e909;
            internal DXGI_RGB e910;
            internal DXGI_RGB e911;
            internal DXGI_RGB e912;
            internal DXGI_RGB e913;
            internal DXGI_RGB e914;
            internal DXGI_RGB e915;
            internal DXGI_RGB e916;
            internal DXGI_RGB e917;
            internal DXGI_RGB e918;
            internal DXGI_RGB e919;
            internal DXGI_RGB e920;
            internal DXGI_RGB e921;
            internal DXGI_RGB e922;
            internal DXGI_RGB e923;
            internal DXGI_RGB e924;
            internal DXGI_RGB e925;
            internal DXGI_RGB e926;
            internal DXGI_RGB e927;
            internal DXGI_RGB e928;
            internal DXGI_RGB e929;
            internal DXGI_RGB e930;
            internal DXGI_RGB e931;
            internal DXGI_RGB e932;
            internal DXGI_RGB e933;
            internal DXGI_RGB e934;
            internal DXGI_RGB e935;
            internal DXGI_RGB e936;
            internal DXGI_RGB e937;
            internal DXGI_RGB e938;
            internal DXGI_RGB e939;
            internal DXGI_RGB e940;
            internal DXGI_RGB e941;
            internal DXGI_RGB e942;
            internal DXGI_RGB e943;
            internal DXGI_RGB e944;
            internal DXGI_RGB e945;
            internal DXGI_RGB e946;
            internal DXGI_RGB e947;
            internal DXGI_RGB e948;
            internal DXGI_RGB e949;
            internal DXGI_RGB e950;
            internal DXGI_RGB e951;
            internal DXGI_RGB e952;
            internal DXGI_RGB e953;
            internal DXGI_RGB e954;
            internal DXGI_RGB e955;
            internal DXGI_RGB e956;
            internal DXGI_RGB e957;
            internal DXGI_RGB e958;
            internal DXGI_RGB e959;
            internal DXGI_RGB e960;
            internal DXGI_RGB e961;
            internal DXGI_RGB e962;
            internal DXGI_RGB e963;
            internal DXGI_RGB e964;
            internal DXGI_RGB e965;
            internal DXGI_RGB e966;
            internal DXGI_RGB e967;
            internal DXGI_RGB e968;
            internal DXGI_RGB e969;
            internal DXGI_RGB e970;
            internal DXGI_RGB e971;
            internal DXGI_RGB e972;
            internal DXGI_RGB e973;
            internal DXGI_RGB e974;
            internal DXGI_RGB e975;
            internal DXGI_RGB e976;
            internal DXGI_RGB e977;
            internal DXGI_RGB e978;
            internal DXGI_RGB e979;
            internal DXGI_RGB e980;
            internal DXGI_RGB e981;
            internal DXGI_RGB e982;
            internal DXGI_RGB e983;
            internal DXGI_RGB e984;
            internal DXGI_RGB e985;
            internal DXGI_RGB e986;
            internal DXGI_RGB e987;
            internal DXGI_RGB e988;
            internal DXGI_RGB e989;
            internal DXGI_RGB e990;
            internal DXGI_RGB e991;
            internal DXGI_RGB e992;
            internal DXGI_RGB e993;
            internal DXGI_RGB e994;
            internal DXGI_RGB e995;
            internal DXGI_RGB e996;
            internal DXGI_RGB e997;
            internal DXGI_RGB e998;
            internal DXGI_RGB e999;
            internal DXGI_RGB e1000;
            internal DXGI_RGB e1001;
            internal DXGI_RGB e1002;
            internal DXGI_RGB e1003;
            internal DXGI_RGB e1004;
            internal DXGI_RGB e1005;
            internal DXGI_RGB e1006;
            internal DXGI_RGB e1007;
            internal DXGI_RGB e1008;
            internal DXGI_RGB e1009;
            internal DXGI_RGB e1010;
            internal DXGI_RGB e1011;
            internal DXGI_RGB e1012;
            internal DXGI_RGB e1013;
            internal DXGI_RGB e1014;
            internal DXGI_RGB e1015;
            internal DXGI_RGB e1016;
            internal DXGI_RGB e1017;
            internal DXGI_RGB e1018;
            internal DXGI_RGB e1019;
            internal DXGI_RGB e1020;
            internal DXGI_RGB e1021;
            internal DXGI_RGB e1022;
            internal DXGI_RGB e1023;
            internal DXGI_RGB e1024;

            public ref DXGI_RGB this[int index] => ref AsSpan()[index];

            public Span<DXGI_RGB> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 1025);
        }
    }
}
