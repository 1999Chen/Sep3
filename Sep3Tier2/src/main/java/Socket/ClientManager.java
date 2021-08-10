package Socket;


import java.net.Socket;
import java.util.HashMap;

public class ClientManager {
    private HashMap<String, Socket> clients = new HashMap();
    private static ClientManager instance = new ClientManager();

    private ClientManager() {
    }

    public static ClientManager getInstance() {
        return instance;
    }

    public void addClient(String userName, Socket socket) {
        this.clients.put(userName, socket);
    }

    public Socket getClient(String userName) {
        return (Socket)this.clients.get(userName);
    }

    public void removeClient(String userName) {
        this.clients.remove(userName);
    }

    public void removeClient(Socket socket) {
        this.clients.remove(socket);
    }
}
