package Shared;

import org.json.JSONObject;

public class Request {

    private String type;
    private JSONObject args;

    public Request(String type, JSONObject args) {
        this.type = type;
        this.args = args;
    }


    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }

    public JSONObject getArgs() {
        return args;
    }

    public void setArgs(JSONObject args) {
        this.args = args;
    }
}
