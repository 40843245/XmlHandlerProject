using System.IO;

namespace XmlHandlerProject.Globals.constants
{
    public static class FilePathConstants
    {
        public static class DirectoryConstants
        {
            // The directory that the document will be saved to (or saved to).
            // > [!NOTE]
            // > Check the directory exists, otherwise, it will throw an exception at runtime.
            public static readonly string DOCUMENT_DIRECTORY = @"D:\solventoSOFT\test folder\outputs\third package\Xceed.Document.NET4";
            public static readonly string ELEMENTS_DIRECTORY = @"D:\solventoSOFT\test folder\elements";

            public static class Test
            {
                public static class Document
                {
                    public static readonly string ROOT_DIRECTORY = @"D:\solventoSOFT\test folder\test documents";
                }
            }
            public static class FigureDirectoryConstants
            {
                public static readonly string FIGURE_DIRECTORY =
                    Path.Combine(
                        FilePathConstants.DirectoryConstants.ELEMENTS_DIRECTORY,
                        "figure"
                    );

                public static readonly string ANIMATION_OR_ANIME_DIRECTORY =
                    Path.Combine(
                        FilePathConstants.DirectoryConstants.FigureDirectoryConstants.FIGURE_DIRECTORY,
                        "animation or anime"
                    );
            }
        }

        public static class Anime
        {
            public static readonly string JAPANESE_ANIME_DIRECTORY =
                   Path.Combine(
                       FilePathConstants.DirectoryConstants.FigureDirectoryConstants.ANIMATION_OR_ANIME_DIRECTORY,
                       "japanese anime"
                   );

            public static class PurismMagica
            {
                public static readonly string PURISM_MAGICA_DIRECTORY =
                    Path.Combine(
                       FilePathConstants.Anime.JAPANESE_ANIME_DIRECTORY,
                       "魔法少女神奇彩虹"
                   );
                public static class Role
                {
                    public static readonly string AI =
                         Path.Combine(
                             FilePathConstants.Anime.PurismMagica.PURISM_MAGICA_DIRECTORY,
                             "ai.jpg"
                    );

                    public static readonly string MIDORI =
                         Path.Combine(
                             FilePathConstants.Anime.PurismMagica.PURISM_MAGICA_DIRECTORY,
                             "midori.jpg"
                    );

                    public static readonly string AKARI =
                         Path.Combine(
                             FilePathConstants.Anime.PurismMagica.PURISM_MAGICA_DIRECTORY,
                             "akari.jpg"
                    );

                    public static readonly string TEACHER =
                         Path.Combine(
                             FilePathConstants.Anime.PurismMagica.PURISM_MAGICA_DIRECTORY,
                             "深海老師.jpg"
                    );
                }
            }
        }

        public static class Animation
        {

            public static readonly string JAPANESE_ANIMATION_DIRECTORY =
                   Path.Combine(
                       FilePathConstants.DirectoryConstants.FigureDirectoryConstants.ANIMATION_OR_ANIME_DIRECTORY,
                       "japanese animation"
                   );

            public static class MySenpaiIsAnnoying
            {
                public static readonly string MY_SENPAI_IS_ANNOYING_DIRECTORY =
                    Path.Combine(
                       FilePathConstants.Animation.JAPANESE_ANIMATION_DIRECTORY,
                       "前輩有夠煩"
                    );


                public static class Role
                {
                    // Futaba Igarashi (五十嵐雙葉)
                    public static readonly string FUTABA_IGARASHI =
                        Path.Combine(
                            FilePathConstants.Animation.MySenpaiIsAnnoying.MY_SENPAI_IS_ANNOYING_DIRECTORY,
                            "五十嵐雙葉.jpg"
                        );
                    // Harumi Takeda (武田晴海(前輩))
                    public static readonly string HARUMI_TAKEDA =
                        Path.Combine(
                            FilePathConstants.Animation.MySenpaiIsAnnoying.MY_SENPAI_IS_ANNOYING_DIRECTORY,
                            "武田晴海.jpg"
                        );
                    // Tōko Sakurai (櫻井桃子)
                    public static readonly string TOKO_SAKURI =
                        Path.Combine(
                            FilePathConstants.Animation.MySenpaiIsAnnoying.MY_SENPAI_IS_ANNOYING_DIRECTORY,
                            "櫻井桃子.jpg"
                        );
                    // Sōta Kazama (風間蒼太)
                    public static readonly string SOTA_KAZAMA =
                        Path.Combine(
                            FilePathConstants.Animation.MySenpaiIsAnnoying.MY_SENPAI_IS_ANNOYING_DIRECTORY,
                            "風間蒼太.jpg"
                        );
                    // Natsumi Kurobe (黑部夏美)
                    public static readonly string NATSUMI_KUROBE =
                        Path.Combine(
                            FilePathConstants.Animation.MySenpaiIsAnnoying.MY_SENPAI_IS_ANNOYING_DIRECTORY,
                            "黑部夏美.jpg"
                        );
                    // Yūto Sakurai (櫻井優人)
                    public static readonly string YUTO_SAKURI =
                        Path.Combine(
                            FilePathConstants.Animation.MySenpaiIsAnnoying.MY_SENPAI_IS_ANNOYING_DIRECTORY,
                            "櫻井優人.jpg"
                        );
                    // Mona Tsukishiro (月城莫娜)
                    public static readonly string MONA_TSUKISHIRO =
                        Path.Combine(
                            FilePathConstants.Animation.MySenpaiIsAnnoying.MY_SENPAI_IS_ANNOYING_DIRECTORY,
                            "月城莫娜.jpg"
                        );
                }
            }

            public static class LoveAfterWorldDomination
            {

                public static readonly string LOVE_AFTER_WORLD_DOMINATION_DIRECTORY =
                    Path.Combine(
                       FilePathConstants.Animation.JAPANESE_ANIMATION_DIRECTORY,
                       "戀愛要在世界征服後"
                    );

                public static class Role
                {
                    // Desumi Magahara (禍原死死美)
                    public static readonly string DESUMI_MAAHARA =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "死神娜娜.jpg"
                        );
                    // Fudo Aikawa (相川不動)
                    public static readonly string FUDO_AIKAWA =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "相川不動.jpg"
                        );
                    // Hayato Ojino (王子野隼人)
                    public static readonly string HAYATO_OJINO =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "王子野隼人.jpg"
                        );
                    // Misaki Jinguji (神宮寺美咲)
                    public static readonly string MISAKI_JINGUJI =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "神宮寺美咲.jpg"
                        );
                    // Haru Arisugawa (有栖川春)
                    public static readonly string HARU_ARISUAWA =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "有栖川春.jpg"
                        );
                    // Daigo Todoroki (轟大吾)
                    public static readonly string DAIGO_TODOROKI =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "轟大吾.jpg"
                        );
                    // Professor Big Gelato (大傑拉特博士)
                    public static readonly string PROFESSOR_BIG_GELATO =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "大傑拉特博士.jpg"
                        );
                    // Supreme Leader Bosslar (博斯拉大總統)
                    public static readonly string SUPREME_LEADER_BOSSLAR =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "博斯拉大總統.jpg"
                        );
                    // Kiki Majima (魔島忌忌)
                    public static readonly string KIKI_MAJIMA =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "魔島忌忌.jpg"
                        );
                    // Kyoko Kuroyuri (黑百合凶子)
                    public static readonly string KYOKO_KUROYURI =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "黑百合凶子.jpg"
                        );
                    // Anna Hojo (寶條闇奈)
                    public static readonly string ANNA_HOJO =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "寶條闇奈.jpg"
                        );
                    // Catapult Snake (カタパルトスネーク)
                    /*
                     * Image not found yet.
                     * public static readonly string CATAPILT_SNAKE = "Catapult Snake";
                     */
                    /*
                     * Image not found yet.
                    // Matchlock Eagle (マッチロックイーグル)
                    public static readonly string MATCHLOCK_EAGLE = "Matchlock Eagle";
                    */
                    /* 
                     * Image not found yet.
                    // Drone Rabbit (ドローンラビット)
                    public static readonly string DRONE_RABBIT = "Drone Rabbit";
                    */
                    // Kira Sanzugawa (三途川鬼羅)
                    public static readonly string KIRA_SANZUGAWA =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "三途川鬼羅.jpg"
                        );
                    // Ran Ran (亂亂)
                    public static readonly string RAN_RAN =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "亂亂.jpg"
                        );
                    /* 
                     * Image not found yet.
                    // Ultimate Phantom (アルティメット・ファントム)
                    public static readonly string ULTIMATE_PHANTOM = "Ultimate Phantom";
                    */
                    // Hellko (ヘル子) (地獄子)
                    public static readonly string HELLOKO =
                        Path.Combine(
                            FilePathConstants.Animation.LoveAfterWorldDomination.LOVE_AFTER_WORLD_DOMINATION_DIRECTORY,
                            "地獄子.jpg"
                        );
                    /*
                     * Image not found yet.
                    // Desuo Magahara (真ヶ原ですお)
                    public static readonly string DESUO_MAGAHARA = "Desuo Magahara";
                    */
                    /*
                     * Image not found yet.
                    // Kirumi Magahara (真ヶ原キルミ)
                    public static readonly string KIRUMI_MAGAHARA = "Kirumi Magahara";
                    */
                    /*
                     * Image not found yet.
                    // Urami Magahara (禍原ウラ美)
                    public static readonly string URAMIN_MAGAHARA = "Urami Magahara";
                    */
                    /*
                     * Image not found yet.
                    // Tsurami Magahara (禍原 ツラ美)
                    public static readonly string TSURAMI_MAGAHARA = "Tsurami Magahara";
                    */
                    /*
                     * Image not found yet.
                    // Anna Hashimoto (橋本杏奈)
                    public static readonly string ANNA_HASHIMOTO = "Anna Hashimoto";
                    */
                }
            }
        }
    }
}
