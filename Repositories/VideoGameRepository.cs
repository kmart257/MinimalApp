using MinimalApp.Models;

namespace MinimalApp.Repositories
{
    public static class VideoGameRepository
    {
        public static List<VideoGameModel> VideoGames = new()
        {
            new() { id = 1, Title = "SEKIRO", Description = "隻腕の狼、戦国に忍ぶ。" },
            new() { id = 2, Title = "Demon's Souls", Description = "圧倒的な表現力で蘇った重厚なダークファンタジーの世界。そこでプレイヤーは、亡国ボーレタリアに潜む凶悪なデーモンを相手に、禁忌の業“魂（ソウル）”の謎に挑みます。" },
            new() { id = 3, Title = "Horizon Zero Dawn", Description = "熟練ハンター「アーロイ」が、古の遺物や謎に満ちた建造物が点在するオープンワールドを探索し謎を解き明かすアクションRPG" },
            new() { id = 4, Title = "Ｍonster Hunter World", Description = "新たな生命の地。狩れ、本能のままに！" },
            new() { id = 5, Title = "Apex Legends", Description = "ヒーローシューターの進化形にようこそ。" },
            new() { id = 6, Title = "ACE COMBAT 7", Description = "プレイヤーがエースパイロットとなって、リアルな空を追求したグラフィック空間を、愛機を駆って360度自由に飛び回る爽快感と、自身の状況判断で敵を選択して撃破する快感、課せられた難局を打破する達成感が楽しめるフライトシューティングです。" },
            new() { id = 7, Title = "仁王", Description = "賊がはびこり妖怪たちが蠢く幽玄の戦国時代を舞台に、実在の人物「三浦按針」をモチーフにした金髪碧眼のサムライ＝ウィリアムが死闘をくりひろげるダーク戦国アクションRPGです。" },
        };
    }
}
