import org.junit.jupiter.api.DisplayName;

import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.*;

class MainTest {


    @org.junit.jupiter.api.Test
    @DisplayName("Test split rows from input")
    void splitInput() {
        String input = "161487713\n" +
                       "057937213";
        int[][] output = {{1, 6, 1, 4, 8, 7, 7, 1, 3},{0, 5, 7, 9, 3, 7, 2, 1, 3}};
        assertTrue(Arrays.deepEquals(output, Main.splitInput(input)));
    }

    @org.junit.jupiter.api.Test
    @DisplayName("Test 1D Matrix")
    void iterating1DMatrix() {
        String input = "019876"; // 0,6 are low points
        assertEquals(8, Main.iteratingMatrix(input));
    }

    @org.junit.jupiter.api.Test
    @DisplayName("Test 2D Matrix")
    void iterating2DMatrix() {
        String input = "019876\n" +
                       "402564"; // 0,0,4 are low points
        assertEquals(7, Main.iteratingMatrix(input));
    }


    @org.junit.jupiter.api.Test
    @DisplayName("Test iterating Matrix")
    void iteratingMatrix() {
        String input2 = "0198765456793498765667899895432323459895457899886789876798656767890198989323997654321296543219876545\n" +
                "9997654345689987654345998789591014598784345798765678965987543459921987978919876543210989694998765432\n" +
                "7898543254568998875657895679989125987653236989654567934597654567899876869899989874349978989899654321\n" +
                "6987654123457899986767894578978939876543125878943478945698875998954945756789999965498769876789965432\n" +
                "5698743016568996799878923489467894985432014567896567896789989899893234545678999876987658765679896545\n" +
                "4987652123789785656999434679379993999654623478998878998894598798789101234567893989876543434598789956\n" +
                "5699543234897654348989645789234989898965434678969989999943987656578992345778932398765432125987679897\n" +
                "6988994345998743219978956890199878787896545989543296987659876548467889476799321459989521019876565689\n" +
                "9877789457898754398767897921986867696789659897654345699769987434345678987896430124987632129865434578\n" +
                "8765678998989766987657889549875456545698998789765456798978964321234589398989945786798747634987521289\n" +
                "9854989549679997896545678956984321234987987678978967987989876544345691239878896897899876545698642456\n" +
                "4543479934598889987656899767993210129976876578999899976899987656457789398969797929956987656789653767\n" +
                "3212567895997678998767954979876343298765465456789798765678999787578899987654689212349999787898769878\n" +
                "2101489959876546789878963298765454987654332347895679954789449898678999876543578923998779898949899989\n" +
                "5232398949988678996989876459876567898765101258954569875694321999989998765432389899899569999136989899\n" +
                "4365457898799789345699989969987698969876232349543456987893210987796989876545456789789498798945679789\n" +
                "5476567997679893234567999898998789246987453458954767898954429896565879987658767899698997587896798678\n" +
                "7677878986545990123456798787899899959876576567895689989896539765434567898767878978587895456789898789\n" +
                "9788989876437889235678989665943999899987689878986789876797698954323459919899989656476794347899989899\n" +
                "9899898984323978956789876543892398788798799989987898765989987993212368929978597642345689256789678999\n" +
                "8954767895434567899899998764791989698689898993299987654979876789423489998765459831234890135794599788\n" +
                "7643456789545679965999879765699878587578987889349876543456985678934567897654345942356789236893987656\n" +
                "6532345697656799974598769876789765432456976678999987432349874567895779929891259843457994347992996546\n" +
                "7821234589869899865987855989899877643567894567989876545498765979999998912989398764567896598989765435\n" +
                "8730123478978998999876543496921989954678923679876987656569879898998787899878989875678999679779976946\n" +
                "7632564567899987989987542965430198765678934598765498897678998787999656798767678976799998789567899897\n" +
                "6543456778924976878999859879641249986789745789879329998789398676789545987654567897897899895456987679\n" +
                "8784569899999865969898767998752356897897659899998910989891299545678939876543598998956788994329876545\n" +
                "9895989968987654856789878997543497998998769989997899878989987634589323987658789999645676789310984234\n" +
                "3976797659876763645678989987654689329439878978986798767679876545678919998769897896534545698929892123\n" +
                "1097895432985432134589392398998789468920989869875987654567998656789998999989946789421434567999799234\n" +
                "9989976943986741014589201299769899878939997756964599543456789767899897895491234579210123479878678965\n" +
                "8976899894697832123678912987654999989898976549943498956567899878989756679210345678921234899764569986\n" +
                "7865788789798947234567899898543498998757997698712987897678935989875437598921234789432345679965998997\n" +
                "6754567679899986349678998789312387898646789987629876999789523998765324456892345678993456798979897898\n" +
                "5433226598998765498989987654101456987534990196534965699898439899854212345789456789989567987899786799\n" +
                "6321012456789977697899998763212359894323491987749854989986598798767301245699987996578979876737655688\n" +
                "8743233767897898986788987654923498765436789998998643878997987679873212346898998965456899965421434667\n" +
                "7654344689976679765647899789899569876545678989987432367898964597654343457987999876567899876510123458\n" +
                "9765656797234598754636798998768999987956989975496541456999896789876456789656890987688954987673234567\n" +
                "3998789896125987653125457897657889999867899876987432346789789893987867892345691998789643498754345778\n" +
                "2139899965434598761012346789547678999978999989998646456895678932198978901256789869995432569965456789\n" +
                "3234999896545699832133487890134567898999989999998657567954567891019989212345678998789321279879597892\n" +
                "4349989789956986543234589999295679967899878999899877679543456789424599935456799997678932389998989921\n" +
                "5698878677897987654345679578989989656798767898789988796532345678935989896567989987567893456797978990\n" +
                "6987664576789998768458789456679694547698756347678999976543456789549978789879879876456789567986567789\n" +
                "9876573465878969877669893234569543234599743236567899987754567898698765678989965985347978979875455699\n" +
                "9995432454567943988789932123678940123987652125456998798765878929987654567899854324236567899954234789\n" +
                "9876210123478952399895321034789432458998761012347997659876989212398543458998743210123478999863135993\n" +
                "9976323234589543456976532165896573467989872123656789745989992101987432134999656321254567899874547894\n" +
                "8765434545697654569876543876997987569876543334567895434598893212976543015899766435367678998765656795\n" +
                "9876549876789767699987656987898998978987654545698954323456789343988754876789899549878989439878767896\n" +
                "7989689989892988789998767898989799399898875698789765454567895454599765989899998756789493323989978997\n" +
                "6798798992921099899899878939976543298769989789999876565678996565999878999989659877896321012498989789\n" +
                "5639897921092125998789989123987654997654599899878999776989789879897989999878943988965432133567897679\n" +
                "4324956899989234989698991019999869876543467999769678997897689998786596988767892199876749545689934599\n" +
                "3212345678978945976567892198989878985432355988756569898987569986653445977656792012987898767895423989\n" +
                "7425656989567959865456789987678989876321234978543458789999498795341239865445689123598989888976519878\n" +
                "6434567894359898764345678996567998765432349865452345678999569653210198764324579235999679999987998767\n" +
                "7587678921239799843239789965456899879545698754321236789998998754421239873213467949894598992399865456\n" +
                "7679989210198678954378999876567896987656799875210123898987899986532349986501678998789987789910999597\n" +
                "8789894321987567896567894987689934698767891984321234987676789997653498795413789987679876669892988989\n" +
                "9898765939876458789698932198794323989898932395432449896545678919764569654329899876567995458799876678\n" +
                "9969879896954345698999545989899319879909543986543498765436789101975679885434998787456984345689765566\n" +
                "9852998765423234767897999878958909768919655987656569896517899919876789976545689654349876456897843445\n" +
                "8643489987610123456976878954347898754598996799789678987698978892987893987656789743256998667896532134\n" +
                "9759579897521234567895667893236789843456789899998789998789768791298932199787895434123498778965431012\n" +
                "9898998765432347688943456789045678932345689987679895989894545679379321019899987321012369899876559423\n" +
                "3987679986543458799432367892127899431256799899562923976943234579459832123999876543143456998997678934\n" +
                "2976565698654567896521456793298986562345898764321019895432123478998763236789988654234587896498789545\n" +
                "3987434598767699987932367895459997878487989897632398789321014567987654445789799895678999989349899856\n" +
                "9897523459878789299893456789568998989568976989543987676932124568998765676797658976799345678996998767\n" +
                "9788412345989890198789569899878999997679895878954976545893238679109877787896547989891249899985459878\n" +
                "8654301234599921987698978976989287898799754767895985437789548789298998898995435695910198999875334989\n" +
                "7543212345678999876567899765690176799987643456796984325678956789987669959789324954321297899654219895\n" +
                "8654323456799987987698999854321245678998321345689875434789767893299542345698919895439986798943109764\n" +
                "9765436567899976598789898767433366989986210123678986546899878954998753457987998789598765987893299843\n" +
                "9887567679979865429896789876549456799965321234567987897899999999898764569976787679999654576789987659\n" +
                "5998789789567978539965656997698967899876432347678998999998999889789875698765436567897643235895499878\n" +
                "4569899897679987698754345698987898976987543656789989789767998775678986987654323456987732146789398989\n" +
                "3478910998998898987653234789996789895498654777898765678956987654589997898843212369876545256893227890\n" +
                "1245699899876799999865545678965456789329769899999954599549876543459998998764101236987984345789106791\n" +
                "0134987654765778998986676989894345678919879932198765988959765432467899987654323345699875656895415899\n" +
                "1949896563244569987698789899789236989998989543249899767898654321348976798765634789789986767894323978\n" +
                "9898765432123456976539899788678949899997897694345987658989965442459345899876545678990987898965434569\n" +
                "8769876551012345895423987657569898789876898985459876545679878643769456799989876789991298929876775778\n" +
                "9854998743256566789109876543469797678965789976569987635589989767978987998999997899873349212997889899\n" +
                "8765987654345689899219765432398654567894678989698965323489999878989999876669998998764569109898998912\n" +
                "9896798965456789978997654521449765678932567898987894313878893989999899944558999439975678998789987101\n" +
                "8987899986567994567998743210139878989543458987876995305456794599878799432347994321986989987678976532\n" +
                "7698999897879543456899765323234989297654569876765789212346789798765678901236789432987899878567899945\n" +
                "4569998798989432345799876436545891019765798765434994323457899899654567892345678949899929765456987896\n" +
                "3445989659699921234689986545656789129879899896549895935668955998743456793456789998779910979345985679\n" +
                "1239876546559892345679197968987899998989998987898789896799943298654567976567999987667899898959874567\n" +
                "0545989632346789467789239879999999897698997698987676789899899398765678987699898976548998787598765789\n" +
                "1356797521248999578997659989901298766567799549976545689988798999989989298989767895439987656469876789\n" +
                "2987985432345678989998767997892987655456678998765434679878697889996799109878658789698765432345987894\n" +
                "3567976765456789998999879876789886844344567989878323598764566978945678998754345678999875321234698943\n" +
                "4568987876567893867894998765498765432123479877945412459843434569236899876543234567999986410126789101\n" +
                "6789998989678912356913987654329874321014698765432101568932012489345789997654123456789994323434893213";
        assertEquals(7, Main.iteratingMatrix(input2));
    }
}