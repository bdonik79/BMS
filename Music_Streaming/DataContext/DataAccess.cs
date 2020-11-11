
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
//using neweb.DataContext;
using Music_Streaming.Models;

namespace DAL
{
    public class DataAccess
    {
        CDA cmd = new CDA();


        public List<Category> getcategory()
        {
            CDA cmd = new CDA();

            DataSet ds = null;
            CategoryList clist = new CategoryList();
            List<Category> contentlist = new List<Category>();

            try
            {
                ds = cmd.GetDataSet("Exec [dbo].[spCategory]", "Music_Streaming");
                // FillRepeater2(ds, Navigation.None, rptr_content, 9);
                Category content = new Category();
   
                //content
                
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    content = new Category();

                    content.Name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    content.Code = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    content.ContentType = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    content.Sort = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    
                    contentlist.Add(content);
                }
            }

            //catch (Exception ex)
            //{
            //    // Response.Redirect("error_page.aspx");
            //}
            finally { } 
            return contentlist;
        }

        public List<Data> getdata(string Code, string ContentType)
        {
            CDA cmd = new CDA();

            DataSet ds = null;
            CategoryList clist = new CategoryList();
            List<Data> contentlist = new List<Data>();

            try
            {
                ds = cmd.GetDataSet("Exec [dbo].[spCategoryContent]'" + Code + "','" + ContentType + "'", "Music_Streaming");
                // FillRepeater2(ds, Navigation.None, rptr_content, 9);
                Data content = new Data();

                //content

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    content = new Data();

                    content.ContentID       = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    content.image           = "http://18.138.2.103:58080/content.music/upload/Batch/" + ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    content.title           = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    content.ContentType     = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    content.Artist          = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    content.Duration        = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    string playUrl          =ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    
                    //if (playUrl.Length > 0)
                    
                        if (content.ContentType =="R")
                        {
                            content.PlayUrl = "http://43.240.103.34/api.shadhin/api/album/" + content.ContentID;
                        }
                        else if (content.ContentType == "P")
                        {
                            content.PlayUrl = "http://43.240.103.34/api.shadhin/api/playlist/" + content.ContentID;
                        }
                        else if (content.ContentType == "A")
                        {
                            content.PlayUrl = "http://43.240.103.34/api.shadhin/api/artist/" + content.ContentID;
                        }
                        else if (playUrl.Length > 0) 
                        { 
                            content.PlayUrl = "http://18.138.2.103:58080/content.music/upload/Batch/" + playUrl; 
                        }
                    
                        else
                        {
                        content.PlayUrl = "";
                        }
                    contentlist.Add(content);
                }
            }

            //catch (Exception ex)
            //{
            //    // Response.Redirect("error_page.aspx");
            //}
            finally { } 
            return contentlist;
        }

        public List<Album> getalbum(string id)
        {
            CDA cmd = new CDA();

            DataSet ds = null;
            CategoryList clist = new CategoryList();
            List<Album> contentlist = new List<Album>();

            try
            {
                ds = cmd.GetDataSet("Exec [dbo].[spAlbumContent]'" + id + "'", "Music_Streaming");
                // FillRepeater2(ds, Navigation.None, rptr_content, 9);
                Album content = new Album();

                //content

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    content = new Album();

                    content.ContentID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    content.image = "http://18.138.2.103:58080/content.music/upload/Batch/" + ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    content.title = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    content.ContentType = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    content.artist = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    content.duration = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    content.copyright = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    content.labelname = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    content.releaseDate = ds.Tables[0].Rows[i].ItemArray[9].ToString();
                    string playUrl = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    if (playUrl.Length > 0)
                    {
                        content.PlayUrl = "http://18.138.2.103:58080/content.music/upload/Batch/" + playUrl;
                    }
                    else
                    {
                        content.PlayUrl = "";
                    }
                    contentlist.Add(content);
                }
            }

            //catch (Exception ex)
            //{
            //    // Response.Redirect("error_page.aspx");
            //}
            finally { } 
            return contentlist;
        }

        public List<Artist> getartist(string id)
        {
            CDA cmd = new CDA();

            DataSet ds = null;
            CategoryList clist = new CategoryList();
            List<Artist> contentlist = new List<Artist>();

            try
            {
                ds = cmd.GetDataSet("Exec [dbo].[spArtistContent]'" + id + "'", "Music_Streaming");
                // FillRepeater2(ds, Navigation.None, rptr_content, 9);
                Artist content = new Artist();

                //content

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    content = new Artist();

                    content.ContentID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    content.image = "http://18.138.2.103:58080/content.music/upload/Batch/" + ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    content.title = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    content.ContentType = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    content.artistname = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    content.duration = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    content.copyright = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    content.labelname = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    content.releaseDate = ds.Tables[0].Rows[i].ItemArray[9].ToString();
                    string playUrl = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    if (playUrl.Length > 0)
                    {
                        content.PlayUrl = "http://18.138.2.103:58080/content.music/upload/Batch/" + playUrl;
                    }
                    else
                    {
                        content.PlayUrl = "";
                    }
                    contentlist.Add(content);
                }
            }

            //catch (Exception ex)
            //{
            //    // Response.Redirect("error_page.aspx");
            //}
            finally { } 
            return contentlist;
        }

        public List<Playlist> getplaylist(string id)
        {
            CDA cmd = new CDA();

            DataSet ds = null;
            CategoryList clist = new CategoryList();
            List<Playlist> contentlist = new List<Playlist>();

            try
            {
                ds = cmd.GetDataSet("Exec [dbo].[spPlaylistContent]'" + id + "'", "Music_Streaming");
                // FillRepeater2(ds, Navigation.None, rptr_content, 9);
                Playlist content = new Playlist();

                //content

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    content = new Playlist();

                    content.ContentID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    content.image = "http://18.138.2.103:58080/content.music/upload/Batch/" + ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    content.title = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    content.ContentType = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    content.artist = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    content.duration = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    content.copyright = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    content.labelname = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    content.releaseDate = ds.Tables[0].Rows[i].ItemArray[9].ToString();
                    string playUrl = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    if (playUrl.Length > 0)
                    {
                        content.PlayUrl = "http://18.138.2.103:58080/content.music/upload/Batch/" + playUrl;
                    }
                    else
                    {
                        content.PlayUrl = "";
                    }
                    contentlist.Add(content);
                }
            }

            //catch (Exception ex)
            //{
            //    // Response.Redirect("error_page.aspx");
            //}
            finally { } 
            return contentlist;
        }

        public List<Song> getsong(string id)
        {
            CDA cmd = new CDA();

            DataSet ds = null;
            CategoryList clist = new CategoryList();
            List<Song> contentlist = new List<Song>();

            try
            {
                ds = cmd.GetDataSet("Exec [dbo].[spPlaylistContent]'" + id + "'", "Music_Streaming");
                // FillRepeater2(ds, Navigation.None, rptr_content, 9);
                Song content = new Song();

                //content

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    content = new Song();

                    content.ContentID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    content.image = "http://18.138.2.103:58080/content.music/upload/Batch/" + ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    content.title = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    content.ContentType = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    content.artistname = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    content.duration = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    content.copyright = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    content.labelname = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    content.releaseDate = ds.Tables[0].Rows[i].ItemArray[9].ToString();
                    string playUrl = ds.Tables[0].Rows[i].ItemArray[4].ToString();
                    if (playUrl.Length > 0)
                    {
                        content.PlayUrl = "http://18.138.2.103:58080/content.music/upload/Batch/" + playUrl;
                    }
                    else
                    {
                        content.PlayUrl = "";
                    }
                    contentlist.Add(content);
                }
            }

            //catch (Exception ex)
            //{
            //    // Response.Redirect("error_page.aspx");
            //}
            finally { } 
            return contentlist;
        }

        public List<Category> getvideocategory()
        {
            CDA cmd = new CDA();

            DataSet ds = null;
            CategoryList clist = new CategoryList();
            List<Category> contentlist = new List<Category>();

            try
            {
                ds = cmd.GetDataSet("Exec [dbo].[spCategoryVedio]", "Music_Streaming");
                // FillRepeater2(ds, Navigation.None, rptr_content, 9);
                Category content = new Category();

                //content

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    content = new Category();

                    content.Name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    content.Code = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    content.ContentType = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    content.Sort = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                    contentlist.Add(content);
                }
            }

            //catch (Exception ex)
            //{
            //    // Response.Redirect("error_page.aspx");
            //}
            finally { } 
            return contentlist;
        }

        public List<Data> getsearch(string Keyword, string ContentType)
        {
            CDA cmd = new CDA();

            DataSet ds = null;
            CategoryList clist = new CategoryList();
            List<Data> contentlist = new List<Data>();

            try
            {
                ds = cmd.GetDataSet("Exec [dbo].[spCategoryContentSearch]'" + Keyword + "','" + ContentType + "'", "Music_Streaming");
                // FillRepeater2(ds, Navigation.None, rptr_content, 9);
                Data content = new Data();

                //content

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    content = new Data();

                    content.ContentID = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    content.image = "http://18.138.2.103:58080/content.music/upload/Batch/" + ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    content.title = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    content.ContentType = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    content.Artist = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    content.Duration = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    string playUrl = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                    if (content.ContentType == "R")
                    {
                        content.PlayUrl = "http://43.240.103.34/api.shadhin/api/album/" + content.ContentID;
                    }
                    else if (content.ContentType == "P")
                    {
                        content.PlayUrl = "http://43.240.103.34/api.shadhin/api/playlist/" + content.ContentID;
                    }
                    else if (content.ContentType == "A")
                    {
                        content.PlayUrl = "http://43.240.103.34/api.shadhin/api/artist/" + content.ContentID;
                    }
                    else if (playUrl.Length > 0)
                    {
                        content.PlayUrl = "http://18.138.2.103:58080/content.music/upload/Batch/" + playUrl;
                    }
                    else
                    {
                        content.PlayUrl = "";
                    }
                    contentlist.Add(content);
                }
            }

            //catch (Exception ex)
            //{
            //     //Response.Redirect("error_page.aspx");
            //}
            finally { } 
            return contentlist;
        }

       

    }
}