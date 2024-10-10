

public class homewor2Task1 {
    public static void main(String[] args) {
        String baseURL = "";
        String params = "";
        if (args.length == 0) {
            baseURL = "https://example.com/search?";
            params = "query=java&sort=desc&filter=null";
        } 
        else {
            baseURL = args[0];
            params = args[1];
        }
        System.out.println(buildURL(baseURL, params));
    }
    public static String buildURL(String baseURL, String params) {
        StringBuilder sb = new StringBuilder(baseURL);
        String[] newParams = params.split("&");

        for (int i = 0; i < newParams.length; i++) {
           String[] newParamsTwo = newParams[i].split("=");
           if (!"null".equals(newParamsTwo[1])) {
                if (i > 0) {
                    sb.append("&");
                }
                sb.append(newParamsTwo[0]).append("=").append(newParamsTwo[1]);
            } 
        } 
    return sb.toString();
    }
}
        