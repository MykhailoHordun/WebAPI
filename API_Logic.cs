using RestSharp;

namespace WebAPI
{
    class API_logic
    {
        public RestClient Get_Upload_client()
        {
            RestClient client = new RestClient("https://content.dropboxapi.com/2/files/upload");
            return client;
        }

        public RestClient Get_GerMetadata_client()
        {
            RestClient client = new RestClient("https://api.dropboxapi.com/2/files/get_metadata");
            return client;
        }

        public RestClient Get_Delete_client()
        {
            RestClient client = new RestClient("https://api.dropboxapi.com/2/files/delete");
            return client;
        }

        public RestClient Get_List_Folder_client()
        {
            RestClient client = new RestClient("https://api.dropboxapi.com/2/files/list_folder");
            return client;
        }

        public RestRequest CreateRequest()
        {
            RestRequest request = new RestRequest(Method.POST);
            return request;
        }

        public void Timeout(RestClient cl)
        {
            cl.Timeout = -1;
        }
        public void Upload_Request(RestRequest request)
        {
            request.AddHeader("Dropbox-API-Arg", "{\"path\": \"/text.txt\",\"mode\": \"add\",\"autorename\": true,\"mute\": false,\"strict_conflict\": false}");
            request.AddHeader("Content-Type", "application/octet-stream");
            request.AddHeader("Authorization", "Bearer sl.A-g1s0mfGTzwko1eGd9kG9OpNMl8Pi2ZaZOSH0wkw_aWJakFFFn1MBoytC_O8sQZVzlvICo96GqtaJ2HA2CqldKEBm94haGQR9HVsuOKcIBI2uZriQ_fQniDfZYhxy7efW704lF9pXB-");
        }

        public void GetMetadata_Request(RestRequest request2)
        {
            request2.AddHeader("Authorization", "Bearer sl.A-g1s0mfGTzwko1eGd9kG9OpNMl8Pi2ZaZOSH0wkw_aWJakFFFn1MBoytC_O8sQZVzlvICo96GqtaJ2HA2CqldKEBm94haGQR9HVsuOKcIBI2uZriQ_fQniDfZYhxy7efW704lF9pXB-"); 
            request2.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" + @"    ""path"": ""/text.txt"" " + "\n" + @"}";
            request2.AddParameter("application/json", body, ParameterType.RequestBody);
        }

        public void Delete_Request(RestRequest request3)
        {
            request3.AddHeader("Authorization", "Bearer sl.A-g1s0mfGTzwko1eGd9kG9OpNMl8Pi2ZaZOSH0wkw_aWJakFFFn1MBoytC_O8sQZVzlvICo96GqtaJ2HA2CqldKEBm94haGQR9HVsuOKcIBI2uZriQ_fQniDfZYhxy7efW704lF9pXB-"); 
            request3.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" + @"    ""path"": ""/text.txt"" " + "\n" + @"}";
            request3.AddParameter("application/json", body, ParameterType.RequestBody);
        }

        public void List_Folder_Request(RestRequest request)
        {
            request.AddHeader("Authorization", "Bearer sl.A-hK0O1bCnNEhFLO5Dg1VEKQvSZWs9OONBKao3Gp4YjhfdXw_69ZJmrFpgeuUCXo-lOHgEkuYlD1j5MdaPKnMCK9IBO6LM2UgBJe8AZ3M1ihENhpAW3kkN0c2y-6f85SCJUgzKvciwsU");
            request.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" +
            @"    ""path"": """",
            " + "\n" +
            @"    ""recursive"": false,
            " + "\n" +
            @"    ""include_media_info"": false,
            " + "\n" +
            @"    ""include_deleted"": false,
            " + "\n" +
            @"    ""include_has_explicit_shared_members"": false,
            " + "\n" +
            @"    ""include_mounted_folders"": true,
            " + "\n" +
            @"    ""include_non_downloadable_files"": true
            " + "\n" +
            @"}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
        }
        public IRestResponse Responce(RestClient client, RestRequest request)
        {
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response;
        }
        public IRestResponse List_Folder_Responce(RestClient client, RestRequest request)
        {
            IRestResponse response = client.Execute(request);
            return response;
        }


    }
}

