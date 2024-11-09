import type { Metadata } from "next";
import "@/styles/globals.css";
import { AppRouterCacheProvider } from "@mui/material-nextjs/v15-appRouter'";
import { Toaster } from "sonner";


export const metadata: Metadata = {
  title: "Poll App",
  description: "Vote for what you like",
};

export default function RootLayout({
  children,
}: Readonly<{
  children: React.ReactNode;
}>) {
  return (
    <html lang="en">
      <body className={``}>
        <AppRouterCacheProvider>
        {children}
        </AppRouterCacheProvider>
        <Toaster />
      </body>
    </html>
  );
}
