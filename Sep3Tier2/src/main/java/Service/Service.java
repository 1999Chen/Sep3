package Service;

import Model.User;
import com.google.gson.Gson;
import okhttp3.MediaType;
import okhttp3.Request;
import okhttp3.RequestBody;
import okhttp3.Response;
import org.json.JSONObject;

import java.io.IOException;

public class Service {
    Gson gson;

    public Service() {
       gson = new Gson();


    }

//    public  synchronized JSONObject Register(User user) throws IOException {
//        System.out.println("registering tier2 API");
//        String json = gson.toJson(user);
//        MediaType mediaType = MediaType.parse("application/json");
//        RequestBody body = RequestBody.create(mediaType, json);
//        Request request = (new Request.Builder()).url("https://localhost:44380/users/Register").method("POST", body).addHeader("Accept", "application/json").addHeader("Content-Type", "application/json").build();
//        Response response = sslClient.newCall(request).execute();
//        return response == null ? new JSONObject("{\"ResponseCode\": \"Can't connect to T3 \"}") : new JSONObject(response.body().string());
//    }







}
