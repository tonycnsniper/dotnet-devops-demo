import { ReactNode } from "react";
import { Box, Container, Grid } from "@radix-ui/themes";

import Navbar from "./Navbar";
import React from "react";

type Props = {
  children: ReactNode;
};

export default function Layout({ children }: Props) {
  return (
    <React.Fragment>
      <Grid className="">
        <Box>
          <Navbar />
        </Box>
        <Box className="">
          {children}
        </Box>
      </Grid>
    </React.Fragment>
  );
}
