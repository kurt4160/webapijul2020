using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebAPISample.Migrations
{
    public partial class FillBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Isbn", "Publisher", "Title" },
                values: new object[,]
                {
                    { 1, "47111", "sample pub", "title 1" },
                    { 659, "4711659", "sample pub", "title 659" },
                    { 660, "4711660", "sample pub", "title 660" },
                    { 661, "4711661", "sample pub", "title 661" },
                    { 662, "4711662", "sample pub", "title 662" },
                    { 663, "4711663", "sample pub", "title 663" },
                    { 664, "4711664", "sample pub", "title 664" },
                    { 665, "4711665", "sample pub", "title 665" },
                    { 666, "4711666", "sample pub", "title 666" },
                    { 667, "4711667", "sample pub", "title 667" },
                    { 668, "4711668", "sample pub", "title 668" },
                    { 669, "4711669", "sample pub", "title 669" },
                    { 670, "4711670", "sample pub", "title 670" },
                    { 671, "4711671", "sample pub", "title 671" },
                    { 672, "4711672", "sample pub", "title 672" },
                    { 673, "4711673", "sample pub", "title 673" },
                    { 674, "4711674", "sample pub", "title 674" },
                    { 675, "4711675", "sample pub", "title 675" },
                    { 676, "4711676", "sample pub", "title 676" },
                    { 677, "4711677", "sample pub", "title 677" },
                    { 678, "4711678", "sample pub", "title 678" },
                    { 679, "4711679", "sample pub", "title 679" },
                    { 680, "4711680", "sample pub", "title 680" },
                    { 681, "4711681", "sample pub", "title 681" },
                    { 682, "4711682", "sample pub", "title 682" },
                    { 683, "4711683", "sample pub", "title 683" },
                    { 684, "4711684", "sample pub", "title 684" },
                    { 685, "4711685", "sample pub", "title 685" },
                    { 658, "4711658", "sample pub", "title 658" },
                    { 686, "4711686", "sample pub", "title 686" },
                    { 657, "4711657", "sample pub", "title 657" },
                    { 655, "4711655", "sample pub", "title 655" },
                    { 628, "4711628", "sample pub", "title 628" },
                    { 629, "4711629", "sample pub", "title 629" },
                    { 630, "4711630", "sample pub", "title 630" },
                    { 631, "4711631", "sample pub", "title 631" },
                    { 632, "4711632", "sample pub", "title 632" },
                    { 633, "4711633", "sample pub", "title 633" },
                    { 634, "4711634", "sample pub", "title 634" },
                    { 635, "4711635", "sample pub", "title 635" },
                    { 636, "4711636", "sample pub", "title 636" },
                    { 637, "4711637", "sample pub", "title 637" },
                    { 638, "4711638", "sample pub", "title 638" },
                    { 639, "4711639", "sample pub", "title 639" },
                    { 640, "4711640", "sample pub", "title 640" },
                    { 641, "4711641", "sample pub", "title 641" },
                    { 642, "4711642", "sample pub", "title 642" },
                    { 643, "4711643", "sample pub", "title 643" },
                    { 644, "4711644", "sample pub", "title 644" },
                    { 645, "4711645", "sample pub", "title 645" },
                    { 646, "4711646", "sample pub", "title 646" },
                    { 647, "4711647", "sample pub", "title 647" },
                    { 648, "4711648", "sample pub", "title 648" },
                    { 649, "4711649", "sample pub", "title 649" },
                    { 650, "4711650", "sample pub", "title 650" },
                    { 651, "4711651", "sample pub", "title 651" },
                    { 652, "4711652", "sample pub", "title 652" },
                    { 653, "4711653", "sample pub", "title 653" },
                    { 654, "4711654", "sample pub", "title 654" },
                    { 656, "4711656", "sample pub", "title 656" },
                    { 687, "4711687", "sample pub", "title 687" },
                    { 688, "4711688", "sample pub", "title 688" },
                    { 689, "4711689", "sample pub", "title 689" },
                    { 722, "4711722", "sample pub", "title 722" },
                    { 723, "4711723", "sample pub", "title 723" },
                    { 724, "4711724", "sample pub", "title 724" },
                    { 725, "4711725", "sample pub", "title 725" },
                    { 726, "4711726", "sample pub", "title 726" },
                    { 727, "4711727", "sample pub", "title 727" },
                    { 728, "4711728", "sample pub", "title 728" },
                    { 729, "4711729", "sample pub", "title 729" },
                    { 730, "4711730", "sample pub", "title 730" },
                    { 731, "4711731", "sample pub", "title 731" },
                    { 732, "4711732", "sample pub", "title 732" },
                    { 733, "4711733", "sample pub", "title 733" },
                    { 734, "4711734", "sample pub", "title 734" },
                    { 735, "4711735", "sample pub", "title 735" },
                    { 736, "4711736", "sample pub", "title 736" },
                    { 737, "4711737", "sample pub", "title 737" },
                    { 738, "4711738", "sample pub", "title 738" },
                    { 739, "4711739", "sample pub", "title 739" },
                    { 740, "4711740", "sample pub", "title 740" },
                    { 741, "4711741", "sample pub", "title 741" },
                    { 742, "4711742", "sample pub", "title 742" },
                    { 743, "4711743", "sample pub", "title 743" },
                    { 744, "4711744", "sample pub", "title 744" },
                    { 745, "4711745", "sample pub", "title 745" },
                    { 746, "4711746", "sample pub", "title 746" },
                    { 747, "4711747", "sample pub", "title 747" },
                    { 748, "4711748", "sample pub", "title 748" },
                    { 721, "4711721", "sample pub", "title 721" },
                    { 720, "4711720", "sample pub", "title 720" },
                    { 719, "4711719", "sample pub", "title 719" },
                    { 718, "4711718", "sample pub", "title 718" },
                    { 690, "4711690", "sample pub", "title 690" },
                    { 691, "4711691", "sample pub", "title 691" },
                    { 692, "4711692", "sample pub", "title 692" },
                    { 693, "4711693", "sample pub", "title 693" },
                    { 694, "4711694", "sample pub", "title 694" },
                    { 695, "4711695", "sample pub", "title 695" },
                    { 696, "4711696", "sample pub", "title 696" },
                    { 697, "4711697", "sample pub", "title 697" },
                    { 698, "4711698", "sample pub", "title 698" },
                    { 699, "4711699", "sample pub", "title 699" },
                    { 700, "4711700", "sample pub", "title 700" },
                    { 701, "4711701", "sample pub", "title 701" },
                    { 702, "4711702", "sample pub", "title 702" },
                    { 627, "4711627", "sample pub", "title 627" },
                    { 703, "4711703", "sample pub", "title 703" },
                    { 705, "4711705", "sample pub", "title 705" },
                    { 706, "4711706", "sample pub", "title 706" },
                    { 707, "4711707", "sample pub", "title 707" },
                    { 708, "4711708", "sample pub", "title 708" },
                    { 709, "4711709", "sample pub", "title 709" },
                    { 710, "4711710", "sample pub", "title 710" },
                    { 711, "4711711", "sample pub", "title 711" },
                    { 712, "4711712", "sample pub", "title 712" },
                    { 713, "4711713", "sample pub", "title 713" },
                    { 714, "4711714", "sample pub", "title 714" },
                    { 715, "4711715", "sample pub", "title 715" },
                    { 716, "4711716", "sample pub", "title 716" },
                    { 717, "4711717", "sample pub", "title 717" },
                    { 704, "4711704", "sample pub", "title 704" },
                    { 749, "4711749", "sample pub", "title 749" },
                    { 626, "4711626", "sample pub", "title 626" },
                    { 624, "4711624", "sample pub", "title 624" },
                    { 534, "4711534", "sample pub", "title 534" },
                    { 535, "4711535", "sample pub", "title 535" },
                    { 536, "4711536", "sample pub", "title 536" },
                    { 537, "4711537", "sample pub", "title 537" },
                    { 538, "4711538", "sample pub", "title 538" },
                    { 539, "4711539", "sample pub", "title 539" },
                    { 540, "4711540", "sample pub", "title 540" },
                    { 541, "4711541", "sample pub", "title 541" },
                    { 542, "4711542", "sample pub", "title 542" },
                    { 543, "4711543", "sample pub", "title 543" },
                    { 544, "4711544", "sample pub", "title 544" },
                    { 545, "4711545", "sample pub", "title 545" },
                    { 546, "4711546", "sample pub", "title 546" },
                    { 547, "4711547", "sample pub", "title 547" },
                    { 548, "4711548", "sample pub", "title 548" },
                    { 549, "4711549", "sample pub", "title 549" },
                    { 550, "4711550", "sample pub", "title 550" },
                    { 551, "4711551", "sample pub", "title 551" },
                    { 552, "4711552", "sample pub", "title 552" },
                    { 553, "4711553", "sample pub", "title 553" },
                    { 554, "4711554", "sample pub", "title 554" },
                    { 555, "4711555", "sample pub", "title 555" },
                    { 556, "4711556", "sample pub", "title 556" },
                    { 557, "4711557", "sample pub", "title 557" },
                    { 558, "4711558", "sample pub", "title 558" },
                    { 559, "4711559", "sample pub", "title 559" },
                    { 560, "4711560", "sample pub", "title 560" },
                    { 533, "4711533", "sample pub", "title 533" },
                    { 561, "4711561", "sample pub", "title 561" },
                    { 532, "4711532", "sample pub", "title 532" },
                    { 530, "4711530", "sample pub", "title 530" },
                    { 503, "4711503", "sample pub", "title 503" },
                    { 504, "4711504", "sample pub", "title 504" },
                    { 505, "4711505", "sample pub", "title 505" },
                    { 506, "4711506", "sample pub", "title 506" },
                    { 507, "4711507", "sample pub", "title 507" },
                    { 508, "4711508", "sample pub", "title 508" },
                    { 509, "4711509", "sample pub", "title 509" },
                    { 510, "4711510", "sample pub", "title 510" },
                    { 511, "4711511", "sample pub", "title 511" },
                    { 512, "4711512", "sample pub", "title 512" },
                    { 513, "4711513", "sample pub", "title 513" },
                    { 514, "4711514", "sample pub", "title 514" },
                    { 515, "4711515", "sample pub", "title 515" },
                    { 516, "4711516", "sample pub", "title 516" },
                    { 517, "4711517", "sample pub", "title 517" },
                    { 518, "4711518", "sample pub", "title 518" },
                    { 519, "4711519", "sample pub", "title 519" },
                    { 520, "4711520", "sample pub", "title 520" },
                    { 521, "4711521", "sample pub", "title 521" },
                    { 522, "4711522", "sample pub", "title 522" },
                    { 523, "4711523", "sample pub", "title 523" },
                    { 524, "4711524", "sample pub", "title 524" },
                    { 525, "4711525", "sample pub", "title 525" },
                    { 526, "4711526", "sample pub", "title 526" },
                    { 527, "4711527", "sample pub", "title 527" },
                    { 528, "4711528", "sample pub", "title 528" },
                    { 529, "4711529", "sample pub", "title 529" },
                    { 531, "4711531", "sample pub", "title 531" },
                    { 562, "4711562", "sample pub", "title 562" },
                    { 563, "4711563", "sample pub", "title 563" },
                    { 564, "4711564", "sample pub", "title 564" },
                    { 597, "4711597", "sample pub", "title 597" },
                    { 598, "4711598", "sample pub", "title 598" },
                    { 599, "4711599", "sample pub", "title 599" },
                    { 600, "4711600", "sample pub", "title 600" },
                    { 601, "4711601", "sample pub", "title 601" },
                    { 602, "4711602", "sample pub", "title 602" },
                    { 603, "4711603", "sample pub", "title 603" },
                    { 604, "4711604", "sample pub", "title 604" },
                    { 605, "4711605", "sample pub", "title 605" },
                    { 606, "4711606", "sample pub", "title 606" },
                    { 607, "4711607", "sample pub", "title 607" },
                    { 608, "4711608", "sample pub", "title 608" },
                    { 609, "4711609", "sample pub", "title 609" },
                    { 610, "4711610", "sample pub", "title 610" },
                    { 611, "4711611", "sample pub", "title 611" },
                    { 612, "4711612", "sample pub", "title 612" },
                    { 613, "4711613", "sample pub", "title 613" },
                    { 614, "4711614", "sample pub", "title 614" },
                    { 615, "4711615", "sample pub", "title 615" },
                    { 616, "4711616", "sample pub", "title 616" },
                    { 617, "4711617", "sample pub", "title 617" },
                    { 618, "4711618", "sample pub", "title 618" },
                    { 619, "4711619", "sample pub", "title 619" },
                    { 620, "4711620", "sample pub", "title 620" },
                    { 621, "4711621", "sample pub", "title 621" },
                    { 622, "4711622", "sample pub", "title 622" },
                    { 623, "4711623", "sample pub", "title 623" },
                    { 596, "4711596", "sample pub", "title 596" },
                    { 595, "4711595", "sample pub", "title 595" },
                    { 594, "4711594", "sample pub", "title 594" },
                    { 593, "4711593", "sample pub", "title 593" },
                    { 565, "4711565", "sample pub", "title 565" },
                    { 566, "4711566", "sample pub", "title 566" },
                    { 567, "4711567", "sample pub", "title 567" },
                    { 568, "4711568", "sample pub", "title 568" },
                    { 569, "4711569", "sample pub", "title 569" },
                    { 570, "4711570", "sample pub", "title 570" },
                    { 571, "4711571", "sample pub", "title 571" },
                    { 572, "4711572", "sample pub", "title 572" },
                    { 573, "4711573", "sample pub", "title 573" },
                    { 574, "4711574", "sample pub", "title 574" },
                    { 575, "4711575", "sample pub", "title 575" },
                    { 576, "4711576", "sample pub", "title 576" },
                    { 577, "4711577", "sample pub", "title 577" },
                    { 625, "4711625", "sample pub", "title 625" },
                    { 578, "4711578", "sample pub", "title 578" },
                    { 580, "4711580", "sample pub", "title 580" },
                    { 581, "4711581", "sample pub", "title 581" },
                    { 582, "4711582", "sample pub", "title 582" },
                    { 583, "4711583", "sample pub", "title 583" },
                    { 584, "4711584", "sample pub", "title 584" },
                    { 585, "4711585", "sample pub", "title 585" },
                    { 586, "4711586", "sample pub", "title 586" },
                    { 587, "4711587", "sample pub", "title 587" },
                    { 588, "4711588", "sample pub", "title 588" },
                    { 589, "4711589", "sample pub", "title 589" },
                    { 590, "4711590", "sample pub", "title 590" },
                    { 591, "4711591", "sample pub", "title 591" },
                    { 592, "4711592", "sample pub", "title 592" },
                    { 579, "4711579", "sample pub", "title 579" },
                    { 502, "4711502", "sample pub", "title 502" },
                    { 750, "4711750", "sample pub", "title 750" },
                    { 752, "4711752", "sample pub", "title 752" },
                    { 909, "4711909", "sample pub", "title 909" },
                    { 910, "4711910", "sample pub", "title 910" },
                    { 911, "4711911", "sample pub", "title 911" },
                    { 912, "4711912", "sample pub", "title 912" },
                    { 913, "4711913", "sample pub", "title 913" },
                    { 914, "4711914", "sample pub", "title 914" },
                    { 915, "4711915", "sample pub", "title 915" },
                    { 916, "4711916", "sample pub", "title 916" },
                    { 917, "4711917", "sample pub", "title 917" },
                    { 918, "4711918", "sample pub", "title 918" },
                    { 919, "4711919", "sample pub", "title 919" },
                    { 920, "4711920", "sample pub", "title 920" },
                    { 921, "4711921", "sample pub", "title 921" },
                    { 922, "4711922", "sample pub", "title 922" },
                    { 923, "4711923", "sample pub", "title 923" },
                    { 924, "4711924", "sample pub", "title 924" },
                    { 925, "4711925", "sample pub", "title 925" },
                    { 926, "4711926", "sample pub", "title 926" },
                    { 927, "4711927", "sample pub", "title 927" },
                    { 928, "4711928", "sample pub", "title 928" },
                    { 929, "4711929", "sample pub", "title 929" },
                    { 930, "4711930", "sample pub", "title 930" },
                    { 931, "4711931", "sample pub", "title 931" },
                    { 932, "4711932", "sample pub", "title 932" },
                    { 933, "4711933", "sample pub", "title 933" },
                    { 934, "4711934", "sample pub", "title 934" },
                    { 935, "4711935", "sample pub", "title 935" },
                    { 908, "4711908", "sample pub", "title 908" },
                    { 936, "4711936", "sample pub", "title 936" },
                    { 907, "4711907", "sample pub", "title 907" },
                    { 905, "4711905", "sample pub", "title 905" },
                    { 878, "4711878", "sample pub", "title 878" },
                    { 879, "4711879", "sample pub", "title 879" },
                    { 880, "4711880", "sample pub", "title 880" },
                    { 881, "4711881", "sample pub", "title 881" },
                    { 882, "4711882", "sample pub", "title 882" },
                    { 883, "4711883", "sample pub", "title 883" },
                    { 884, "4711884", "sample pub", "title 884" },
                    { 885, "4711885", "sample pub", "title 885" },
                    { 886, "4711886", "sample pub", "title 886" },
                    { 887, "4711887", "sample pub", "title 887" },
                    { 888, "4711888", "sample pub", "title 888" },
                    { 889, "4711889", "sample pub", "title 889" },
                    { 890, "4711890", "sample pub", "title 890" },
                    { 891, "4711891", "sample pub", "title 891" },
                    { 892, "4711892", "sample pub", "title 892" },
                    { 893, "4711893", "sample pub", "title 893" },
                    { 894, "4711894", "sample pub", "title 894" },
                    { 895, "4711895", "sample pub", "title 895" },
                    { 896, "4711896", "sample pub", "title 896" },
                    { 897, "4711897", "sample pub", "title 897" },
                    { 898, "4711898", "sample pub", "title 898" },
                    { 899, "4711899", "sample pub", "title 899" },
                    { 900, "4711900", "sample pub", "title 900" },
                    { 901, "4711901", "sample pub", "title 901" },
                    { 902, "4711902", "sample pub", "title 902" },
                    { 903, "4711903", "sample pub", "title 903" },
                    { 904, "4711904", "sample pub", "title 904" },
                    { 906, "4711906", "sample pub", "title 906" },
                    { 937, "4711937", "sample pub", "title 937" },
                    { 938, "4711938", "sample pub", "title 938" },
                    { 939, "4711939", "sample pub", "title 939" },
                    { 972, "4711972", "sample pub", "title 972" },
                    { 973, "4711973", "sample pub", "title 973" },
                    { 974, "4711974", "sample pub", "title 974" },
                    { 975, "4711975", "sample pub", "title 975" },
                    { 976, "4711976", "sample pub", "title 976" },
                    { 977, "4711977", "sample pub", "title 977" },
                    { 978, "4711978", "sample pub", "title 978" },
                    { 979, "4711979", "sample pub", "title 979" },
                    { 980, "4711980", "sample pub", "title 980" },
                    { 981, "4711981", "sample pub", "title 981" },
                    { 982, "4711982", "sample pub", "title 982" },
                    { 983, "4711983", "sample pub", "title 983" },
                    { 984, "4711984", "sample pub", "title 984" },
                    { 985, "4711985", "sample pub", "title 985" },
                    { 986, "4711986", "sample pub", "title 986" },
                    { 987, "4711987", "sample pub", "title 987" },
                    { 988, "4711988", "sample pub", "title 988" },
                    { 989, "4711989", "sample pub", "title 989" },
                    { 990, "4711990", "sample pub", "title 990" },
                    { 991, "4711991", "sample pub", "title 991" },
                    { 992, "4711992", "sample pub", "title 992" },
                    { 993, "4711993", "sample pub", "title 993" },
                    { 994, "4711994", "sample pub", "title 994" },
                    { 995, "4711995", "sample pub", "title 995" },
                    { 996, "4711996", "sample pub", "title 996" },
                    { 997, "4711997", "sample pub", "title 997" },
                    { 998, "4711998", "sample pub", "title 998" },
                    { 971, "4711971", "sample pub", "title 971" },
                    { 970, "4711970", "sample pub", "title 970" },
                    { 969, "4711969", "sample pub", "title 969" },
                    { 968, "4711968", "sample pub", "title 968" },
                    { 940, "4711940", "sample pub", "title 940" },
                    { 941, "4711941", "sample pub", "title 941" },
                    { 942, "4711942", "sample pub", "title 942" },
                    { 943, "4711943", "sample pub", "title 943" },
                    { 944, "4711944", "sample pub", "title 944" },
                    { 945, "4711945", "sample pub", "title 945" },
                    { 946, "4711946", "sample pub", "title 946" },
                    { 947, "4711947", "sample pub", "title 947" },
                    { 948, "4711948", "sample pub", "title 948" },
                    { 949, "4711949", "sample pub", "title 949" },
                    { 950, "4711950", "sample pub", "title 950" },
                    { 951, "4711951", "sample pub", "title 951" },
                    { 952, "4711952", "sample pub", "title 952" },
                    { 877, "4711877", "sample pub", "title 877" },
                    { 953, "4711953", "sample pub", "title 953" },
                    { 955, "4711955", "sample pub", "title 955" },
                    { 956, "4711956", "sample pub", "title 956" },
                    { 957, "4711957", "sample pub", "title 957" },
                    { 958, "4711958", "sample pub", "title 958" },
                    { 959, "4711959", "sample pub", "title 959" },
                    { 960, "4711960", "sample pub", "title 960" },
                    { 961, "4711961", "sample pub", "title 961" },
                    { 962, "4711962", "sample pub", "title 962" },
                    { 963, "4711963", "sample pub", "title 963" },
                    { 964, "4711964", "sample pub", "title 964" },
                    { 965, "4711965", "sample pub", "title 965" },
                    { 966, "4711966", "sample pub", "title 966" },
                    { 967, "4711967", "sample pub", "title 967" },
                    { 954, "4711954", "sample pub", "title 954" },
                    { 751, "4711751", "sample pub", "title 751" },
                    { 876, "4711876", "sample pub", "title 876" },
                    { 874, "4711874", "sample pub", "title 874" },
                    { 784, "4711784", "sample pub", "title 784" },
                    { 785, "4711785", "sample pub", "title 785" },
                    { 786, "4711786", "sample pub", "title 786" },
                    { 787, "4711787", "sample pub", "title 787" },
                    { 788, "4711788", "sample pub", "title 788" },
                    { 789, "4711789", "sample pub", "title 789" },
                    { 790, "4711790", "sample pub", "title 790" },
                    { 791, "4711791", "sample pub", "title 791" },
                    { 792, "4711792", "sample pub", "title 792" },
                    { 793, "4711793", "sample pub", "title 793" },
                    { 794, "4711794", "sample pub", "title 794" },
                    { 795, "4711795", "sample pub", "title 795" },
                    { 796, "4711796", "sample pub", "title 796" },
                    { 797, "4711797", "sample pub", "title 797" },
                    { 798, "4711798", "sample pub", "title 798" },
                    { 799, "4711799", "sample pub", "title 799" },
                    { 800, "4711800", "sample pub", "title 800" },
                    { 801, "4711801", "sample pub", "title 801" },
                    { 802, "4711802", "sample pub", "title 802" },
                    { 803, "4711803", "sample pub", "title 803" },
                    { 804, "4711804", "sample pub", "title 804" },
                    { 805, "4711805", "sample pub", "title 805" },
                    { 806, "4711806", "sample pub", "title 806" },
                    { 807, "4711807", "sample pub", "title 807" },
                    { 808, "4711808", "sample pub", "title 808" },
                    { 809, "4711809", "sample pub", "title 809" },
                    { 810, "4711810", "sample pub", "title 810" },
                    { 783, "4711783", "sample pub", "title 783" },
                    { 811, "4711811", "sample pub", "title 811" },
                    { 782, "4711782", "sample pub", "title 782" },
                    { 780, "4711780", "sample pub", "title 780" },
                    { 753, "4711753", "sample pub", "title 753" },
                    { 754, "4711754", "sample pub", "title 754" },
                    { 755, "4711755", "sample pub", "title 755" },
                    { 756, "4711756", "sample pub", "title 756" },
                    { 757, "4711757", "sample pub", "title 757" },
                    { 758, "4711758", "sample pub", "title 758" },
                    { 759, "4711759", "sample pub", "title 759" },
                    { 760, "4711760", "sample pub", "title 760" },
                    { 761, "4711761", "sample pub", "title 761" },
                    { 762, "4711762", "sample pub", "title 762" },
                    { 763, "4711763", "sample pub", "title 763" },
                    { 764, "4711764", "sample pub", "title 764" },
                    { 765, "4711765", "sample pub", "title 765" },
                    { 766, "4711766", "sample pub", "title 766" },
                    { 767, "4711767", "sample pub", "title 767" },
                    { 768, "4711768", "sample pub", "title 768" },
                    { 769, "4711769", "sample pub", "title 769" },
                    { 770, "4711770", "sample pub", "title 770" },
                    { 771, "4711771", "sample pub", "title 771" },
                    { 772, "4711772", "sample pub", "title 772" },
                    { 773, "4711773", "sample pub", "title 773" },
                    { 774, "4711774", "sample pub", "title 774" },
                    { 775, "4711775", "sample pub", "title 775" },
                    { 776, "4711776", "sample pub", "title 776" },
                    { 777, "4711777", "sample pub", "title 777" },
                    { 778, "4711778", "sample pub", "title 778" },
                    { 779, "4711779", "sample pub", "title 779" },
                    { 781, "4711781", "sample pub", "title 781" },
                    { 812, "4711812", "sample pub", "title 812" },
                    { 813, "4711813", "sample pub", "title 813" },
                    { 814, "4711814", "sample pub", "title 814" },
                    { 847, "4711847", "sample pub", "title 847" },
                    { 848, "4711848", "sample pub", "title 848" },
                    { 849, "4711849", "sample pub", "title 849" },
                    { 850, "4711850", "sample pub", "title 850" },
                    { 851, "4711851", "sample pub", "title 851" },
                    { 852, "4711852", "sample pub", "title 852" },
                    { 853, "4711853", "sample pub", "title 853" },
                    { 854, "4711854", "sample pub", "title 854" },
                    { 855, "4711855", "sample pub", "title 855" },
                    { 856, "4711856", "sample pub", "title 856" },
                    { 857, "4711857", "sample pub", "title 857" },
                    { 858, "4711858", "sample pub", "title 858" },
                    { 859, "4711859", "sample pub", "title 859" },
                    { 860, "4711860", "sample pub", "title 860" },
                    { 861, "4711861", "sample pub", "title 861" },
                    { 862, "4711862", "sample pub", "title 862" },
                    { 863, "4711863", "sample pub", "title 863" },
                    { 864, "4711864", "sample pub", "title 864" },
                    { 865, "4711865", "sample pub", "title 865" },
                    { 866, "4711866", "sample pub", "title 866" },
                    { 867, "4711867", "sample pub", "title 867" },
                    { 868, "4711868", "sample pub", "title 868" },
                    { 869, "4711869", "sample pub", "title 869" },
                    { 870, "4711870", "sample pub", "title 870" },
                    { 871, "4711871", "sample pub", "title 871" },
                    { 872, "4711872", "sample pub", "title 872" },
                    { 873, "4711873", "sample pub", "title 873" },
                    { 846, "4711846", "sample pub", "title 846" },
                    { 845, "4711845", "sample pub", "title 845" },
                    { 844, "4711844", "sample pub", "title 844" },
                    { 843, "4711843", "sample pub", "title 843" },
                    { 815, "4711815", "sample pub", "title 815" },
                    { 816, "4711816", "sample pub", "title 816" },
                    { 817, "4711817", "sample pub", "title 817" },
                    { 818, "4711818", "sample pub", "title 818" },
                    { 819, "4711819", "sample pub", "title 819" },
                    { 820, "4711820", "sample pub", "title 820" },
                    { 821, "4711821", "sample pub", "title 821" },
                    { 822, "4711822", "sample pub", "title 822" },
                    { 823, "4711823", "sample pub", "title 823" },
                    { 824, "4711824", "sample pub", "title 824" },
                    { 825, "4711825", "sample pub", "title 825" },
                    { 826, "4711826", "sample pub", "title 826" },
                    { 827, "4711827", "sample pub", "title 827" },
                    { 875, "4711875", "sample pub", "title 875" },
                    { 828, "4711828", "sample pub", "title 828" },
                    { 830, "4711830", "sample pub", "title 830" },
                    { 831, "4711831", "sample pub", "title 831" },
                    { 832, "4711832", "sample pub", "title 832" },
                    { 833, "4711833", "sample pub", "title 833" },
                    { 834, "4711834", "sample pub", "title 834" },
                    { 835, "4711835", "sample pub", "title 835" },
                    { 836, "4711836", "sample pub", "title 836" },
                    { 837, "4711837", "sample pub", "title 837" },
                    { 838, "4711838", "sample pub", "title 838" },
                    { 839, "4711839", "sample pub", "title 839" },
                    { 840, "4711840", "sample pub", "title 840" },
                    { 841, "4711841", "sample pub", "title 841" },
                    { 842, "4711842", "sample pub", "title 842" },
                    { 829, "4711829", "sample pub", "title 829" },
                    { 501, "4711501", "sample pub", "title 501" },
                    { 500, "4711500", "sample pub", "title 500" },
                    { 499, "4711499", "sample pub", "title 499" },
                    { 158, "4711158", "sample pub", "title 158" },
                    { 159, "4711159", "sample pub", "title 159" },
                    { 160, "4711160", "sample pub", "title 160" },
                    { 161, "4711161", "sample pub", "title 161" },
                    { 162, "4711162", "sample pub", "title 162" },
                    { 163, "4711163", "sample pub", "title 163" },
                    { 164, "4711164", "sample pub", "title 164" },
                    { 165, "4711165", "sample pub", "title 165" },
                    { 166, "4711166", "sample pub", "title 166" },
                    { 167, "4711167", "sample pub", "title 167" },
                    { 168, "4711168", "sample pub", "title 168" },
                    { 169, "4711169", "sample pub", "title 169" },
                    { 170, "4711170", "sample pub", "title 170" },
                    { 171, "4711171", "sample pub", "title 171" },
                    { 172, "4711172", "sample pub", "title 172" },
                    { 173, "4711173", "sample pub", "title 173" },
                    { 174, "4711174", "sample pub", "title 174" },
                    { 175, "4711175", "sample pub", "title 175" },
                    { 176, "4711176", "sample pub", "title 176" },
                    { 177, "4711177", "sample pub", "title 177" },
                    { 178, "4711178", "sample pub", "title 178" },
                    { 179, "4711179", "sample pub", "title 179" },
                    { 180, "4711180", "sample pub", "title 180" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Isbn", "Publisher", "Title" },
                values: new object[,]
                {
                    { 181, "4711181", "sample pub", "title 181" },
                    { 182, "4711182", "sample pub", "title 182" },
                    { 183, "4711183", "sample pub", "title 183" },
                    { 184, "4711184", "sample pub", "title 184" },
                    { 157, "4711157", "sample pub", "title 157" },
                    { 185, "4711185", "sample pub", "title 185" },
                    { 156, "4711156", "sample pub", "title 156" },
                    { 154, "4711154", "sample pub", "title 154" },
                    { 127, "4711127", "sample pub", "title 127" },
                    { 128, "4711128", "sample pub", "title 128" },
                    { 129, "4711129", "sample pub", "title 129" },
                    { 130, "4711130", "sample pub", "title 130" },
                    { 131, "4711131", "sample pub", "title 131" },
                    { 132, "4711132", "sample pub", "title 132" },
                    { 133, "4711133", "sample pub", "title 133" },
                    { 134, "4711134", "sample pub", "title 134" },
                    { 135, "4711135", "sample pub", "title 135" },
                    { 136, "4711136", "sample pub", "title 136" },
                    { 137, "4711137", "sample pub", "title 137" },
                    { 138, "4711138", "sample pub", "title 138" },
                    { 139, "4711139", "sample pub", "title 139" },
                    { 140, "4711140", "sample pub", "title 140" },
                    { 141, "4711141", "sample pub", "title 141" },
                    { 142, "4711142", "sample pub", "title 142" },
                    { 143, "4711143", "sample pub", "title 143" },
                    { 144, "4711144", "sample pub", "title 144" },
                    { 145, "4711145", "sample pub", "title 145" },
                    { 146, "4711146", "sample pub", "title 146" },
                    { 147, "4711147", "sample pub", "title 147" },
                    { 148, "4711148", "sample pub", "title 148" },
                    { 149, "4711149", "sample pub", "title 149" },
                    { 150, "4711150", "sample pub", "title 150" },
                    { 151, "4711151", "sample pub", "title 151" },
                    { 152, "4711152", "sample pub", "title 152" },
                    { 153, "4711153", "sample pub", "title 153" },
                    { 155, "4711155", "sample pub", "title 155" },
                    { 186, "4711186", "sample pub", "title 186" },
                    { 187, "4711187", "sample pub", "title 187" },
                    { 188, "4711188", "sample pub", "title 188" },
                    { 221, "4711221", "sample pub", "title 221" },
                    { 222, "4711222", "sample pub", "title 222" },
                    { 223, "4711223", "sample pub", "title 223" },
                    { 224, "4711224", "sample pub", "title 224" },
                    { 225, "4711225", "sample pub", "title 225" },
                    { 226, "4711226", "sample pub", "title 226" },
                    { 227, "4711227", "sample pub", "title 227" },
                    { 228, "4711228", "sample pub", "title 228" },
                    { 229, "4711229", "sample pub", "title 229" },
                    { 230, "4711230", "sample pub", "title 230" },
                    { 231, "4711231", "sample pub", "title 231" },
                    { 232, "4711232", "sample pub", "title 232" },
                    { 233, "4711233", "sample pub", "title 233" },
                    { 234, "4711234", "sample pub", "title 234" },
                    { 235, "4711235", "sample pub", "title 235" },
                    { 236, "4711236", "sample pub", "title 236" },
                    { 237, "4711237", "sample pub", "title 237" },
                    { 238, "4711238", "sample pub", "title 238" },
                    { 239, "4711239", "sample pub", "title 239" },
                    { 240, "4711240", "sample pub", "title 240" },
                    { 241, "4711241", "sample pub", "title 241" },
                    { 242, "4711242", "sample pub", "title 242" },
                    { 243, "4711243", "sample pub", "title 243" },
                    { 244, "4711244", "sample pub", "title 244" },
                    { 245, "4711245", "sample pub", "title 245" },
                    { 246, "4711246", "sample pub", "title 246" },
                    { 247, "4711247", "sample pub", "title 247" },
                    { 220, "4711220", "sample pub", "title 220" },
                    { 219, "4711219", "sample pub", "title 219" },
                    { 218, "4711218", "sample pub", "title 218" },
                    { 217, "4711217", "sample pub", "title 217" },
                    { 189, "4711189", "sample pub", "title 189" },
                    { 190, "4711190", "sample pub", "title 190" },
                    { 191, "4711191", "sample pub", "title 191" },
                    { 192, "4711192", "sample pub", "title 192" },
                    { 193, "4711193", "sample pub", "title 193" },
                    { 194, "4711194", "sample pub", "title 194" },
                    { 195, "4711195", "sample pub", "title 195" },
                    { 196, "4711196", "sample pub", "title 196" },
                    { 197, "4711197", "sample pub", "title 197" },
                    { 198, "4711198", "sample pub", "title 198" },
                    { 199, "4711199", "sample pub", "title 199" },
                    { 200, "4711200", "sample pub", "title 200" },
                    { 201, "4711201", "sample pub", "title 201" },
                    { 126, "4711126", "sample pub", "title 126" },
                    { 202, "4711202", "sample pub", "title 202" },
                    { 204, "4711204", "sample pub", "title 204" },
                    { 205, "4711205", "sample pub", "title 205" },
                    { 206, "4711206", "sample pub", "title 206" },
                    { 207, "4711207", "sample pub", "title 207" },
                    { 208, "4711208", "sample pub", "title 208" },
                    { 209, "4711209", "sample pub", "title 209" },
                    { 210, "4711210", "sample pub", "title 210" },
                    { 211, "4711211", "sample pub", "title 211" },
                    { 212, "4711212", "sample pub", "title 212" },
                    { 213, "4711213", "sample pub", "title 213" },
                    { 214, "4711214", "sample pub", "title 214" },
                    { 215, "4711215", "sample pub", "title 215" },
                    { 216, "4711216", "sample pub", "title 216" },
                    { 203, "4711203", "sample pub", "title 203" },
                    { 248, "4711248", "sample pub", "title 248" },
                    { 125, "4711125", "sample pub", "title 125" },
                    { 123, "4711123", "sample pub", "title 123" },
                    { 33, "471133", "sample pub", "title 33" },
                    { 34, "471134", "sample pub", "title 34" },
                    { 35, "471135", "sample pub", "title 35" },
                    { 36, "471136", "sample pub", "title 36" },
                    { 37, "471137", "sample pub", "title 37" },
                    { 38, "471138", "sample pub", "title 38" },
                    { 39, "471139", "sample pub", "title 39" },
                    { 40, "471140", "sample pub", "title 40" },
                    { 41, "471141", "sample pub", "title 41" },
                    { 42, "471142", "sample pub", "title 42" },
                    { 43, "471143", "sample pub", "title 43" },
                    { 44, "471144", "sample pub", "title 44" },
                    { 45, "471145", "sample pub", "title 45" },
                    { 46, "471146", "sample pub", "title 46" },
                    { 47, "471147", "sample pub", "title 47" },
                    { 48, "471148", "sample pub", "title 48" },
                    { 49, "471149", "sample pub", "title 49" },
                    { 50, "471150", "sample pub", "title 50" },
                    { 51, "471151", "sample pub", "title 51" },
                    { 52, "471152", "sample pub", "title 52" },
                    { 53, "471153", "sample pub", "title 53" },
                    { 54, "471154", "sample pub", "title 54" },
                    { 55, "471155", "sample pub", "title 55" },
                    { 56, "471156", "sample pub", "title 56" },
                    { 57, "471157", "sample pub", "title 57" },
                    { 58, "471158", "sample pub", "title 58" },
                    { 59, "471159", "sample pub", "title 59" },
                    { 32, "471132", "sample pub", "title 32" },
                    { 60, "471160", "sample pub", "title 60" },
                    { 31, "471131", "sample pub", "title 31" },
                    { 29, "471129", "sample pub", "title 29" },
                    { 2, "47112", "sample pub", "title 2" },
                    { 3, "47113", "sample pub", "title 3" },
                    { 4, "47114", "sample pub", "title 4" },
                    { 5, "47115", "sample pub", "title 5" },
                    { 6, "47116", "sample pub", "title 6" },
                    { 7, "47117", "sample pub", "title 7" },
                    { 8, "47118", "sample pub", "title 8" },
                    { 9, "47119", "sample pub", "title 9" },
                    { 10, "471110", "sample pub", "title 10" },
                    { 11, "471111", "sample pub", "title 11" },
                    { 12, "471112", "sample pub", "title 12" },
                    { 13, "471113", "sample pub", "title 13" },
                    { 14, "471114", "sample pub", "title 14" },
                    { 15, "471115", "sample pub", "title 15" },
                    { 16, "471116", "sample pub", "title 16" },
                    { 17, "471117", "sample pub", "title 17" },
                    { 18, "471118", "sample pub", "title 18" },
                    { 19, "471119", "sample pub", "title 19" },
                    { 20, "471120", "sample pub", "title 20" },
                    { 21, "471121", "sample pub", "title 21" },
                    { 22, "471122", "sample pub", "title 22" },
                    { 23, "471123", "sample pub", "title 23" },
                    { 24, "471124", "sample pub", "title 24" },
                    { 25, "471125", "sample pub", "title 25" },
                    { 26, "471126", "sample pub", "title 26" },
                    { 27, "471127", "sample pub", "title 27" },
                    { 28, "471128", "sample pub", "title 28" },
                    { 30, "471130", "sample pub", "title 30" },
                    { 61, "471161", "sample pub", "title 61" },
                    { 62, "471162", "sample pub", "title 62" },
                    { 63, "471163", "sample pub", "title 63" },
                    { 96, "471196", "sample pub", "title 96" },
                    { 97, "471197", "sample pub", "title 97" },
                    { 98, "471198", "sample pub", "title 98" },
                    { 99, "471199", "sample pub", "title 99" },
                    { 100, "4711100", "sample pub", "title 100" },
                    { 101, "4711101", "sample pub", "title 101" },
                    { 102, "4711102", "sample pub", "title 102" },
                    { 103, "4711103", "sample pub", "title 103" },
                    { 104, "4711104", "sample pub", "title 104" },
                    { 105, "4711105", "sample pub", "title 105" },
                    { 106, "4711106", "sample pub", "title 106" },
                    { 107, "4711107", "sample pub", "title 107" },
                    { 108, "4711108", "sample pub", "title 108" },
                    { 109, "4711109", "sample pub", "title 109" },
                    { 110, "4711110", "sample pub", "title 110" },
                    { 111, "4711111", "sample pub", "title 111" },
                    { 112, "4711112", "sample pub", "title 112" },
                    { 113, "4711113", "sample pub", "title 113" },
                    { 114, "4711114", "sample pub", "title 114" },
                    { 115, "4711115", "sample pub", "title 115" },
                    { 116, "4711116", "sample pub", "title 116" },
                    { 117, "4711117", "sample pub", "title 117" },
                    { 118, "4711118", "sample pub", "title 118" },
                    { 119, "4711119", "sample pub", "title 119" },
                    { 120, "4711120", "sample pub", "title 120" },
                    { 121, "4711121", "sample pub", "title 121" },
                    { 122, "4711122", "sample pub", "title 122" },
                    { 95, "471195", "sample pub", "title 95" },
                    { 94, "471194", "sample pub", "title 94" },
                    { 93, "471193", "sample pub", "title 93" },
                    { 92, "471192", "sample pub", "title 92" },
                    { 64, "471164", "sample pub", "title 64" },
                    { 65, "471165", "sample pub", "title 65" },
                    { 66, "471166", "sample pub", "title 66" },
                    { 67, "471167", "sample pub", "title 67" },
                    { 68, "471168", "sample pub", "title 68" },
                    { 69, "471169", "sample pub", "title 69" },
                    { 70, "471170", "sample pub", "title 70" },
                    { 71, "471171", "sample pub", "title 71" },
                    { 72, "471172", "sample pub", "title 72" },
                    { 73, "471173", "sample pub", "title 73" },
                    { 74, "471174", "sample pub", "title 74" },
                    { 75, "471175", "sample pub", "title 75" },
                    { 76, "471176", "sample pub", "title 76" },
                    { 124, "4711124", "sample pub", "title 124" },
                    { 77, "471177", "sample pub", "title 77" },
                    { 79, "471179", "sample pub", "title 79" },
                    { 80, "471180", "sample pub", "title 80" },
                    { 81, "471181", "sample pub", "title 81" },
                    { 82, "471182", "sample pub", "title 82" },
                    { 83, "471183", "sample pub", "title 83" },
                    { 84, "471184", "sample pub", "title 84" },
                    { 85, "471185", "sample pub", "title 85" },
                    { 86, "471186", "sample pub", "title 86" },
                    { 87, "471187", "sample pub", "title 87" },
                    { 88, "471188", "sample pub", "title 88" },
                    { 89, "471189", "sample pub", "title 89" },
                    { 90, "471190", "sample pub", "title 90" },
                    { 91, "471191", "sample pub", "title 91" },
                    { 78, "471178", "sample pub", "title 78" },
                    { 249, "4711249", "sample pub", "title 249" },
                    { 250, "4711250", "sample pub", "title 250" },
                    { 251, "4711251", "sample pub", "title 251" },
                    { 409, "4711409", "sample pub", "title 409" },
                    { 410, "4711410", "sample pub", "title 410" },
                    { 411, "4711411", "sample pub", "title 411" },
                    { 412, "4711412", "sample pub", "title 412" },
                    { 413, "4711413", "sample pub", "title 413" },
                    { 414, "4711414", "sample pub", "title 414" },
                    { 415, "4711415", "sample pub", "title 415" },
                    { 416, "4711416", "sample pub", "title 416" },
                    { 417, "4711417", "sample pub", "title 417" },
                    { 418, "4711418", "sample pub", "title 418" },
                    { 419, "4711419", "sample pub", "title 419" },
                    { 420, "4711420", "sample pub", "title 420" },
                    { 421, "4711421", "sample pub", "title 421" },
                    { 422, "4711422", "sample pub", "title 422" },
                    { 423, "4711423", "sample pub", "title 423" },
                    { 424, "4711424", "sample pub", "title 424" },
                    { 425, "4711425", "sample pub", "title 425" },
                    { 426, "4711426", "sample pub", "title 426" },
                    { 427, "4711427", "sample pub", "title 427" },
                    { 428, "4711428", "sample pub", "title 428" },
                    { 429, "4711429", "sample pub", "title 429" },
                    { 430, "4711430", "sample pub", "title 430" },
                    { 431, "4711431", "sample pub", "title 431" },
                    { 432, "4711432", "sample pub", "title 432" },
                    { 433, "4711433", "sample pub", "title 433" },
                    { 434, "4711434", "sample pub", "title 434" },
                    { 435, "4711435", "sample pub", "title 435" },
                    { 408, "4711408", "sample pub", "title 408" },
                    { 436, "4711436", "sample pub", "title 436" },
                    { 407, "4711407", "sample pub", "title 407" },
                    { 405, "4711405", "sample pub", "title 405" },
                    { 378, "4711378", "sample pub", "title 378" },
                    { 379, "4711379", "sample pub", "title 379" },
                    { 380, "4711380", "sample pub", "title 380" },
                    { 381, "4711381", "sample pub", "title 381" },
                    { 382, "4711382", "sample pub", "title 382" },
                    { 383, "4711383", "sample pub", "title 383" },
                    { 384, "4711384", "sample pub", "title 384" },
                    { 385, "4711385", "sample pub", "title 385" },
                    { 386, "4711386", "sample pub", "title 386" },
                    { 387, "4711387", "sample pub", "title 387" },
                    { 388, "4711388", "sample pub", "title 388" },
                    { 389, "4711389", "sample pub", "title 389" },
                    { 390, "4711390", "sample pub", "title 390" },
                    { 391, "4711391", "sample pub", "title 391" },
                    { 392, "4711392", "sample pub", "title 392" },
                    { 393, "4711393", "sample pub", "title 393" },
                    { 394, "4711394", "sample pub", "title 394" },
                    { 395, "4711395", "sample pub", "title 395" },
                    { 396, "4711396", "sample pub", "title 396" },
                    { 397, "4711397", "sample pub", "title 397" },
                    { 398, "4711398", "sample pub", "title 398" },
                    { 399, "4711399", "sample pub", "title 399" },
                    { 400, "4711400", "sample pub", "title 400" },
                    { 401, "4711401", "sample pub", "title 401" },
                    { 402, "4711402", "sample pub", "title 402" },
                    { 403, "4711403", "sample pub", "title 403" },
                    { 404, "4711404", "sample pub", "title 404" },
                    { 406, "4711406", "sample pub", "title 406" },
                    { 437, "4711437", "sample pub", "title 437" },
                    { 438, "4711438", "sample pub", "title 438" },
                    { 439, "4711439", "sample pub", "title 439" },
                    { 472, "4711472", "sample pub", "title 472" },
                    { 473, "4711473", "sample pub", "title 473" },
                    { 474, "4711474", "sample pub", "title 474" },
                    { 475, "4711475", "sample pub", "title 475" },
                    { 476, "4711476", "sample pub", "title 476" },
                    { 477, "4711477", "sample pub", "title 477" },
                    { 478, "4711478", "sample pub", "title 478" },
                    { 479, "4711479", "sample pub", "title 479" },
                    { 480, "4711480", "sample pub", "title 480" },
                    { 481, "4711481", "sample pub", "title 481" },
                    { 482, "4711482", "sample pub", "title 482" },
                    { 483, "4711483", "sample pub", "title 483" },
                    { 484, "4711484", "sample pub", "title 484" },
                    { 485, "4711485", "sample pub", "title 485" },
                    { 486, "4711486", "sample pub", "title 486" },
                    { 487, "4711487", "sample pub", "title 487" },
                    { 488, "4711488", "sample pub", "title 488" },
                    { 489, "4711489", "sample pub", "title 489" },
                    { 490, "4711490", "sample pub", "title 490" },
                    { 491, "4711491", "sample pub", "title 491" },
                    { 492, "4711492", "sample pub", "title 492" },
                    { 493, "4711493", "sample pub", "title 493" },
                    { 494, "4711494", "sample pub", "title 494" },
                    { 495, "4711495", "sample pub", "title 495" },
                    { 496, "4711496", "sample pub", "title 496" },
                    { 497, "4711497", "sample pub", "title 497" },
                    { 498, "4711498", "sample pub", "title 498" },
                    { 471, "4711471", "sample pub", "title 471" },
                    { 470, "4711470", "sample pub", "title 470" },
                    { 469, "4711469", "sample pub", "title 469" },
                    { 468, "4711468", "sample pub", "title 468" },
                    { 440, "4711440", "sample pub", "title 440" },
                    { 441, "4711441", "sample pub", "title 441" },
                    { 442, "4711442", "sample pub", "title 442" },
                    { 443, "4711443", "sample pub", "title 443" },
                    { 444, "4711444", "sample pub", "title 444" },
                    { 445, "4711445", "sample pub", "title 445" },
                    { 446, "4711446", "sample pub", "title 446" },
                    { 447, "4711447", "sample pub", "title 447" },
                    { 448, "4711448", "sample pub", "title 448" },
                    { 449, "4711449", "sample pub", "title 449" },
                    { 450, "4711450", "sample pub", "title 450" },
                    { 451, "4711451", "sample pub", "title 451" },
                    { 452, "4711452", "sample pub", "title 452" },
                    { 377, "4711377", "sample pub", "title 377" },
                    { 453, "4711453", "sample pub", "title 453" },
                    { 455, "4711455", "sample pub", "title 455" },
                    { 456, "4711456", "sample pub", "title 456" },
                    { 457, "4711457", "sample pub", "title 457" },
                    { 458, "4711458", "sample pub", "title 458" },
                    { 459, "4711459", "sample pub", "title 459" },
                    { 460, "4711460", "sample pub", "title 460" },
                    { 461, "4711461", "sample pub", "title 461" },
                    { 462, "4711462", "sample pub", "title 462" },
                    { 463, "4711463", "sample pub", "title 463" },
                    { 464, "4711464", "sample pub", "title 464" },
                    { 465, "4711465", "sample pub", "title 465" },
                    { 466, "4711466", "sample pub", "title 466" },
                    { 467, "4711467", "sample pub", "title 467" },
                    { 454, "4711454", "sample pub", "title 454" },
                    { 376, "4711376", "sample pub", "title 376" },
                    { 375, "4711375", "sample pub", "title 375" },
                    { 374, "4711374", "sample pub", "title 374" },
                    { 284, "4711284", "sample pub", "title 284" },
                    { 285, "4711285", "sample pub", "title 285" },
                    { 286, "4711286", "sample pub", "title 286" },
                    { 287, "4711287", "sample pub", "title 287" },
                    { 288, "4711288", "sample pub", "title 288" },
                    { 289, "4711289", "sample pub", "title 289" },
                    { 290, "4711290", "sample pub", "title 290" },
                    { 291, "4711291", "sample pub", "title 291" },
                    { 292, "4711292", "sample pub", "title 292" },
                    { 293, "4711293", "sample pub", "title 293" },
                    { 294, "4711294", "sample pub", "title 294" },
                    { 295, "4711295", "sample pub", "title 295" },
                    { 296, "4711296", "sample pub", "title 296" },
                    { 297, "4711297", "sample pub", "title 297" },
                    { 298, "4711298", "sample pub", "title 298" },
                    { 299, "4711299", "sample pub", "title 299" },
                    { 300, "4711300", "sample pub", "title 300" },
                    { 301, "4711301", "sample pub", "title 301" },
                    { 302, "4711302", "sample pub", "title 302" },
                    { 303, "4711303", "sample pub", "title 303" },
                    { 304, "4711304", "sample pub", "title 304" },
                    { 305, "4711305", "sample pub", "title 305" },
                    { 306, "4711306", "sample pub", "title 306" },
                    { 307, "4711307", "sample pub", "title 307" },
                    { 308, "4711308", "sample pub", "title 308" },
                    { 309, "4711309", "sample pub", "title 309" },
                    { 310, "4711310", "sample pub", "title 310" },
                    { 283, "4711283", "sample pub", "title 283" },
                    { 282, "4711282", "sample pub", "title 282" },
                    { 281, "4711281", "sample pub", "title 281" },
                    { 280, "4711280", "sample pub", "title 280" },
                    { 252, "4711252", "sample pub", "title 252" },
                    { 253, "4711253", "sample pub", "title 253" },
                    { 254, "4711254", "sample pub", "title 254" },
                    { 255, "4711255", "sample pub", "title 255" },
                    { 256, "4711256", "sample pub", "title 256" },
                    { 257, "4711257", "sample pub", "title 257" },
                    { 258, "4711258", "sample pub", "title 258" },
                    { 259, "4711259", "sample pub", "title 259" },
                    { 260, "4711260", "sample pub", "title 260" },
                    { 261, "4711261", "sample pub", "title 261" },
                    { 262, "4711262", "sample pub", "title 262" },
                    { 263, "4711263", "sample pub", "title 263" },
                    { 264, "4711264", "sample pub", "title 264" },
                    { 311, "4711311", "sample pub", "title 311" },
                    { 265, "4711265", "sample pub", "title 265" },
                    { 267, "4711267", "sample pub", "title 267" },
                    { 268, "4711268", "sample pub", "title 268" },
                    { 269, "4711269", "sample pub", "title 269" },
                    { 270, "4711270", "sample pub", "title 270" },
                    { 271, "4711271", "sample pub", "title 271" },
                    { 272, "4711272", "sample pub", "title 272" },
                    { 273, "4711273", "sample pub", "title 273" },
                    { 274, "4711274", "sample pub", "title 274" },
                    { 275, "4711275", "sample pub", "title 275" },
                    { 276, "4711276", "sample pub", "title 276" },
                    { 277, "4711277", "sample pub", "title 277" },
                    { 278, "4711278", "sample pub", "title 278" },
                    { 279, "4711279", "sample pub", "title 279" },
                    { 266, "4711266", "sample pub", "title 266" },
                    { 999, "4711999", "sample pub", "title 999" },
                    { 312, "4711312", "sample pub", "title 312" },
                    { 314, "4711314", "sample pub", "title 314" },
                    { 347, "4711347", "sample pub", "title 347" },
                    { 348, "4711348", "sample pub", "title 348" },
                    { 349, "4711349", "sample pub", "title 349" },
                    { 350, "4711350", "sample pub", "title 350" },
                    { 351, "4711351", "sample pub", "title 351" },
                    { 352, "4711352", "sample pub", "title 352" },
                    { 353, "4711353", "sample pub", "title 353" },
                    { 354, "4711354", "sample pub", "title 354" },
                    { 355, "4711355", "sample pub", "title 355" },
                    { 356, "4711356", "sample pub", "title 356" },
                    { 357, "4711357", "sample pub", "title 357" },
                    { 358, "4711358", "sample pub", "title 358" },
                    { 359, "4711359", "sample pub", "title 359" },
                    { 360, "4711360", "sample pub", "title 360" },
                    { 361, "4711361", "sample pub", "title 361" },
                    { 362, "4711362", "sample pub", "title 362" },
                    { 363, "4711363", "sample pub", "title 363" },
                    { 364, "4711364", "sample pub", "title 364" },
                    { 365, "4711365", "sample pub", "title 365" },
                    { 366, "4711366", "sample pub", "title 366" },
                    { 367, "4711367", "sample pub", "title 367" },
                    { 368, "4711368", "sample pub", "title 368" },
                    { 369, "4711369", "sample pub", "title 369" },
                    { 370, "4711370", "sample pub", "title 370" },
                    { 371, "4711371", "sample pub", "title 371" },
                    { 372, "4711372", "sample pub", "title 372" },
                    { 373, "4711373", "sample pub", "title 373" },
                    { 346, "4711346", "sample pub", "title 346" },
                    { 345, "4711345", "sample pub", "title 345" },
                    { 344, "4711344", "sample pub", "title 344" },
                    { 343, "4711343", "sample pub", "title 343" },
                    { 315, "4711315", "sample pub", "title 315" },
                    { 316, "4711316", "sample pub", "title 316" },
                    { 317, "4711317", "sample pub", "title 317" },
                    { 318, "4711318", "sample pub", "title 318" },
                    { 319, "4711319", "sample pub", "title 319" },
                    { 320, "4711320", "sample pub", "title 320" },
                    { 321, "4711321", "sample pub", "title 321" },
                    { 322, "4711322", "sample pub", "title 322" },
                    { 323, "4711323", "sample pub", "title 323" },
                    { 324, "4711324", "sample pub", "title 324" },
                    { 325, "4711325", "sample pub", "title 325" },
                    { 326, "4711326", "sample pub", "title 326" },
                    { 327, "4711327", "sample pub", "title 327" },
                    { 313, "4711313", "sample pub", "title 313" },
                    { 328, "4711328", "sample pub", "title 328" },
                    { 330, "4711330", "sample pub", "title 330" },
                    { 331, "4711331", "sample pub", "title 331" },
                    { 332, "4711332", "sample pub", "title 332" },
                    { 333, "4711333", "sample pub", "title 333" },
                    { 334, "4711334", "sample pub", "title 334" },
                    { 335, "4711335", "sample pub", "title 335" },
                    { 336, "4711336", "sample pub", "title 336" },
                    { 337, "4711337", "sample pub", "title 337" },
                    { 338, "4711338", "sample pub", "title 338" },
                    { 339, "4711339", "sample pub", "title 339" },
                    { 340, "4711340", "sample pub", "title 340" },
                    { 341, "4711341", "sample pub", "title 341" },
                    { 342, "4711342", "sample pub", "title 342" },
                    { 329, "4711329", "sample pub", "title 329" },
                    { 1000, "47111000", "sample pub", "title 1000" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1000);
        }
    }
}
