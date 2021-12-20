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
            request.AddHeader("Authorization", "Bearer sl.A-juopRD9vurYdU4ZTFCxCXjhWTJDxrYvxBfOM8LTJDH3yhD5tMQZQvQ7cdBUWhV4OmqEanRRjRvnPbZ8jyLRhvVhDWLBScbIl3ELhXMiq4TcjlawmBbxJ6hZF-N4_6FZl3abCX5jk-X");
        }

        public void GetMetadata_Request(RestRequest request2)
        {
            request2.AddHeader("Authorization", "Bearer sl.A-gibOXGMqNc4J3rYZk9TuN5v_kbM2qA7HQunAVHjtNk8pEXZlll2sgpK51u5xhYv_G3UEfiY75hMCq7YJpVZZnsmpXSBYbPGFB-8b9AEQMBR9eXjC-jHrpC9HrNAHf8gs1FNH1q8sSS"); 
            request2.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" + @"    ""path"": ""/text.txt"" " + "\n" + @"}";
            request2.AddParameter("application/json", body, ParameterType.RequestBody);
        }

        public void Delete_Request(RestRequest request3)
        {
            request3.AddHeader("Authorization", "Bearer sl.A-iqHvt5seNnfHmyP0KlSAv2GPFMSNXsmiL2VkIoqklMwkPshwIKA6i_SZMDAXp7HshFjud-IPyZUNsq_1yNnhPgO9KBYhhr8BjNUFyBKoCcMCDuvGsO46rUTbJ6Y4K_c73wEEpUyuP8"); 
            request3.AddHeader("Content-Type", "application/json");
            var body = @"{" + "\n" + @"    ""path"": ""/text.txt"" " + "\n" + @"}";
            request3.AddParameter("application/json", body, ParameterType.RequestBody);
        }

        
        public IRestResponse Responce(RestClient client, RestRequest request)
        {
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            return response;
        }

    }
}

