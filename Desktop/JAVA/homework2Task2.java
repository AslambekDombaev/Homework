public class homework2Task2 {
    public static void main(String[] args) {
        String[] headers = {};
        String[][] data = {};
        if (args.length == 0) {
            headers = new String[]{"Name", "Age", "City"};
            data = new String[][] {
                {"John", "30", "New York"},
                {"Alice", "25", "Los Angeles"},
                {"Bob", "35", "Chicago"}
            };
        } 

        System.out.println(csvCode(headers, data));
    }
    
    public static String csvCode(String[] headers, String[][] data) {
        StringBuilder sb = new StringBuilder();
        
        sb.append(String.join(",", headers)).append("\n");
        for (String[] strings : data) {
            sb.append(String.join(",", strings)).append("\n");
        }
        return sb.toString().trim();
    }
}

