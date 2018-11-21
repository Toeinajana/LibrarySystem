using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessLogic
{
    public class MediaLogic
    {
        private MediaDAO mediaDAO;
        private MediaDS.ViewMediaDataTable mediaTable;
        private MediaDS.TabLanguageDataTable languageTable;
        private MediaDS.TabGenreDataTable genreTable;

        public MediaLogic()
        {
            mediaDAO = new MediaDAO();
            mediaTable = new MediaDS.ViewMediaDataTable();
            languageTable = new MediaDS.TabLanguageDataTable();
            genreTable = new MediaDS.TabGenreDataTable();
        }

        public List<MediaModel> ListMedia()
        {
            List<MediaModel> medias = new List<MediaModel>();
            mediaTable = mediaDAO.ListMedia();

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }
        public List<MediaModel> ListMediaByPublishYear(int publishYear)
        {
            List<MediaModel> medias = new List<MediaModel>();
            mediaTable = mediaDAO.ListMediaByPublishYear(publishYear);

            foreach (MediaDS.ViewMediaRow row in mediaTable.Rows)
            {
                MediaModel media = MediaModel.Parse(row);
                medias.Add(media);
            }
            return medias;
        }
        public List<PairModel> ListLanguages()
        {
            List<PairModel> list = new List<PairModel>();
            languageTable = mediaDAO.ListLanguages();
            foreach (MediaDS.TabLanguageRow row in languageTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                list.Add(pair);
            }
            return list;
        }
        public List<PairModel> ListGenres()
        {
            List<PairModel> list = new List<PairModel>();
            genreTable = mediaDAO.ListGenres();
            foreach (MediaDS.TabGenreRow row in genreTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                list.Add(pair);
            }
            return list;
        }
    }
}
