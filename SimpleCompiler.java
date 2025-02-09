# Java Compiler

import java.io.*;
import javax.tools.*;

public class SimpleCompiler {
    public static void main(String[] args) {
        String sourceCode = "public class HelloWorld { " +
                            "public static void main(String[] args) { " +
                            "System.out.println(\"Hello, World!\"); " +
                            "} " +
                            "}";

        JavaCompiler compiler = ToolProvider.getSystemJavaCompiler();
        StandardJavaFileManager fileManager = compiler.getStandardFileManager(null, null, null);

        try {
            // Create a temporary source file
            File tempFile = File.createTempFile("HelloWorld", ".java");
            try (PrintWriter out = new PrintWriter(tempFile)) {
                out.println(sourceCode);
            }

            // Compile the source file
            Iterable<? extends JavaFileObject> compilationUnits = fileManager.getJavaFileObjectsFromFiles(Arrays.asList(tempFile));
            compiler.getTask(null, fileManager, null, null, null, compilationUnits).call();

            // Load and execute the compiled class
            URLClassLoader classLoader = URLClassLoader.newInstance(new URL[]{tempFile.getParentFile().toURI().toURL()});
            Class<?> cls = Class.forName("HelloWorld", true, classLoader);
            cls.getMethod("main", String[].class).invoke(null, (Object) new String[]{});

        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            try {
                fileManager.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }
}
