using System.Threading.Tasks;

namespace Poi.API
{
    //api/v4/bilibili_channels?ids={name1,name2...}
    //hololive,hololive_en,hololive_id,sora,roboco,miko,suisei,fubuki,matsuri,haato,aki,mel,choco,choco_alt,shion,aqua,subaru,ayame,pekora,rushia,flare,marine,noel,kanata,coco,watame,towa,himemoriluna,lamy,nene,botan,polka,laplus,lui,koyori,chloe,iroha,mio,okayu,korone,azki,risu,moona,iofi,ollie,melfissa,reine,vestia,kaela,kobo,amelia,calliope,gura,inanis,kiara,irys,sana,ceres,ouro,mumei,hakos,nana,ui,pochimaru,ayamy,nabi
    public class GetBilibiliChannels
    {
        public long updatedAt { get; set; }
        public Channel[] channels { get; set; }
    }

    public partial class PoiAPI
    {
        public async Task<GetBilibiliChannels> GetBilibiliChannels(string[] vtuberIds)
        {
            string param = "?ids=";
            for(int i = 0; i < vtuberIds.Length; i++)
            {
                param += vtuberIds[i];
                if(i < vtuberIds.Length - 1)
                {
                    param +=",";
                }
            }

            return await HttpHelper.GET<GetBilibiliChannels>(
                httpClient,
                $"https://holoapi.poi.cat/api/v4/bilibili_channels{param}",
                headers
            );
        }
    }
}