package Socket;


import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class StartServer {
    public static ServerSocket serverSocket = null;

    public StartServer() {
    }

    public static void main(String[] args) {
        new Socket();

        try {
            while(true) {
                Socket socket = serverSocket.accept();
                (new ServerThread(socket)).start();
            }
        } catch (Exception var3) {
            var3.printStackTrace();
        }
    }

    static {
        try {
            serverSocket = new ServerSocket(8500);
        } catch (IOException var1) {
            var1.printStackTrace();
        }

    }
}
